using Colab.Models;
using Colab.Requests;

namespace Colab.Repositories;
public interface IUserRepository
{
    Task<IEnumerable<User>> GetUsers();
    Task<User> GetUser(int id);
    Task<User> UpdateUser(UserRequest user,string originUrl);
    Task<User> CreateUser(User user);
    Task<User> DeleteUser(int id);
    Task<User> findByEmail(string email);
    Task sendVerificationEmail(int id, string url);
    Task<User> verifyEmail(string token);
    Task forgotPassword(string email, string url);
    Task resetPassword(string token, string password, string confirmPassword);
    Task<IEnumerable<User>> search(string query);

}