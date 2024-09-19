using System.IdentityModel.Tokens.Jwt;
using Colab.Domain.Models;

namespace Colab.Services;
public interface ITokenService
{
    public int getUserId();
    public bool isAdmin();
    public string getRole();    
    public JwtSecurityToken generateToken(User user);
}