using System.IdentityModel.Tokens.Jwt;
using Colab.Models;
using Colab.Requests;
using Colab.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Colab.Repositories;

namespace Colab.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AuthController : ControllerBase
{
    private readonly MainDbContext _context;   
    private readonly ITokenService _tokenService;
    private readonly IUserRepository _userRepository;


    public AuthController(MainDbContext context, IConfiguration configuration, ITokenService tokenService, IUserRepository userRepository)
    {
        _context = context;
        _tokenService = tokenService;
        _userRepository = userRepository;
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

        if (!BCrypt.Net.BCrypt.Verify(user.Password, userFromDb.Password))
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
        };

        await _userRepository.CreateUser(user);

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
                isAdmin = user.IsAdmin
            }
        });


    }
    // check if user exists using the email
    private async Task<User> getUserByEmail(string email)
    {
        return await _context.Users.FirstOrDefaultAsync(u => u.Email == email);
    }

}