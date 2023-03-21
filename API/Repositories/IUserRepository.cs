using Colab.Models;
namespace Colab.Repositories;
public interface IUserRepository{
    Task<IEnumerable<User>> GetUsers();
    Task<User> GetUser(int id);
    Task<User> UpdateUser(User user);
    Task<User> CreateUser(User user);
    Task<User> DeleteUser(int id);    
    Task<User> findByEmail(string email);
}