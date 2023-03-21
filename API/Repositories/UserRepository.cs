using Colab.Models;
using Microsoft.EntityFrameworkCore;

namespace Colab.Repositories;


public class UserRepository : IUserRepository
{
    private readonly MainDbContext _context;
    public UserRepository(MainDbContext context)
    {
        _context = context;
    }
    public async Task<IEnumerable<User>> GetUsers()
    {
        return await _context.Users.ToListAsync();
    }

    public async Task<User> GetUser(int id)
    {
        return await _context.Users.FindAsync(id);
    }
    public async Task<User> UpdateUser(User user)
    {
        _context.Entry(user).State = EntityState.Modified;
        await _context.SaveChangesAsync();
        return user;
    }
    public async Task<User> CreateUser(User user)
    {
        _context.Users.Add(user);
        await _context.SaveChangesAsync();
        return user;
    }
    public async Task<User> DeleteUser(int id)
    {
        var user = await _context.Users.FindAsync(id);
        if (user == null)
        {
            return null;
        }
        _context.Users.Remove(user);
        await _context.SaveChangesAsync();
        return user;
    }

    public async Task<User> findByEmail(string email)
    {
        var user = await _context.Users.FirstOrDefaultAsync(u => u.Email == email);
        return user;

    }

}