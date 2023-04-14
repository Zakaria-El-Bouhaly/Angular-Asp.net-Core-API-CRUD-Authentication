using Colab.Models;
using Colab.Requests;

namespace Colab.Repositories;
public interface IUserRepository
{
    Task<IEnumerable<User>> GetUsers();
    Task<User> GetUser(int id);
    Task<User> UpdateUser(UserRequest user);
    Task<User> CreateUser(User user);
    Task<User> DeleteUser(int id);
    Task<User> findByEmail(string email);
    Task sendVerificationEmail(int id);
    Task<User> verifyEmail(string token);
    Task forgotPassword(string email);
    Task resetPassword(string token, string password, string confirmPassword);

}