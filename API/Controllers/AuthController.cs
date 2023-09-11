using Colab.Models;
using Colab.Requests;
using Colab.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Colab.Repositories;
using Google.Apis.Auth;
using System.IdentityModel.Tokens.Jwt;

namespace Colab.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AuthController : ControllerBase
{
    private readonly MainDbContext _context;
    private readonly ITokenService _tokenService;
    private readonly IUserRepository _userRepository;
    private readonly IConfiguration _configuration;

    // httpClient instance to make http requests
    private readonly HttpClient _httpClient;


    public AuthController(MainDbContext context, IConfiguration configuration, ITokenService tokenService, IUserRepository userRepository, HttpClient httpClient)
    {
        _context = context;
        _tokenService = tokenService;
        _userRepository = userRepository;
        _configuration = configuration;
        _httpClient = httpClient;

    }

    [HttpPost("login")]
    public async Task<IActionResult> Login(LoginRequest user)
    {

        var userFromDb = await _userRepository.findByEmail(user.Email);

        ModelState.AddModelError("errors", "Email or password is incorrect");

        if (userFromDb == null)
        {
            return BadRequest(ModelState);
        }

        if (!BCrypt.Net.BCrypt.Verify(user.Password, userFromDb.Password) || userFromDb.IsVerified == false)
        {
            return BadRequest(ModelState);
        }

        return generateJwt(userFromDb);

    }



    [HttpPost("register")]
    public async Task<ActionResult<User>> Register(RegisterRequest request)
    {
        var userFromDb = await _userRepository.findByEmail(request.Email);
        if (userFromDb != null)
        {

            ModelState.AddModelError("errors", "Email is already in use");
            return BadRequest(ModelState);
        }

        var user = new User
        {
            Name = request.Name,
            Email = request.Email,
            Password = BCrypt.Net.BCrypt.HashPassword(request.Password),
            profilePicture = "profile-images/default.png"
        };

        await _userRepository.CreateUser(user);

        await _userRepository.sendVerificationEmail(user.Id, Request.Headers["origin"]);

        // return created successfully message response
        return Ok(new { message = "User created successfully" });
    }


    private IActionResult generateJwt(User user)
    {
        //create claims details based on the user information
        JwtSecurityToken token = _tokenService.generateToken(user);

        // return token with user info
        return Ok(new
        {
            token = new JwtSecurityTokenHandler().WriteToken(token),
            user = new
            {
                id = user.Id,
                name = user.Name,
                email = user.Email,
                profilePicture = user.profilePicture,
                isAdmin = user.IsAdmin
            }
        });


    }
    // check if user exists using the email
    private async Task<User> getUserByEmail(string email)
    {
        return await _context.Users.FirstOrDefaultAsync(u => u.Email == email);
    }

    [HttpPost]
    [Route("loginWithGoogle")]
    public async Task<IActionResult> loginWithGoogle(GoogleCredentials googleCredentials)
    {

        var settings = new GoogleJsonWebSignature.ValidationSettings()
        {
            Audience = new List<string> { this._configuration["Google:ClientId"] }
        };
        var payload = await GoogleJsonWebSignature.ValidateAsync(googleCredentials.credential, settings);

        var user = await _userRepository.findByEmail(payload.Email);

        if (user != null)
        {
            return generateJwt(user);
        }
        else
        {
            var newUser = new User
            {
                Name = payload.Name,
                Email = payload.Email,
                Password = BCrypt.Net.BCrypt.HashPassword(payload.Email),
                IsVerified = true,
                profilePicture = "profile-images/default.png"
            };

            var createdUser = await _userRepository.CreateUser(newUser);

            // return Ok(_tokenService.generateToken(createdUser));
            return generateJwt(createdUser);
        }

    }



}