using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Colab.Models;
using Colab.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.IdentityModel.Tokens;

namespace Colab.Services;

public class JwtService : ITokenService
{
    private readonly IHttpContextAccessor _httpContextAccessor;
    private readonly IConfiguration _configuration;

    private readonly IUserRepository _userRepository;

    public JwtService(IHttpContextAccessor httpContextAccessor, IConfiguration configuration, IUserRepository userRepository)
    {
        _httpContextAccessor = httpContextAccessor;
        _configuration = configuration;
        _userRepository = userRepository;
    }

    public int getUserId()
    {
        var userId = _httpContextAccessor?.HttpContext?.User.FindFirst("id")?.Value;
        return int.Parse(userId ?? "0");
    }

    public bool isAdmin()
    {
        var role = _httpContextAccessor?.HttpContext?.User.FindFirst("role")?.Value;
        return role == "Admin";
    }

    public string getRole()
    {
        var role = _httpContextAccessor?.HttpContext?.User.FindFirst("role")?.Value ?? "User";
        return role;
    }

    public JwtSecurityToken generateToken(User user)
    {
        //create claims details based on the user information
        var role = user.IsAdmin ? "Admin" : "User";

        var claims = new[] {
                        new Claim(JwtRegisteredClaimNames.Sub, _configuration["Jwt:Subject"]),
                        new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                        new Claim(JwtRegisteredClaimNames.Iat, DateTime.UtcNow.ToString()),
                        new Claim("id", user.Id.ToString()),
                        new Claim(ClaimTypes.Role, role)
                    };

        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));
        var signIn = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
        var token = new JwtSecurityToken(
            _configuration["Jwt:Issuer"],
            _configuration["Jwt:Audience"],
            claims,
            expires: DateTime.UtcNow.AddMinutes(20),
            signingCredentials: signIn);

        // return token with user info
        return token;
    }


}