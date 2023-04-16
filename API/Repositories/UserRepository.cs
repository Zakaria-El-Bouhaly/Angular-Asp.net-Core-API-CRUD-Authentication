using System.Text;
using System.Web;
using Colab.Models;
using Colab.Requests;
using Colab.Services;
using Microsoft.EntityFrameworkCore;

namespace Colab.Repositories;


public class UserRepository : IUserRepository
{
    private readonly MainDbContext _context;
    private readonly IEmailService _emailService;
    private readonly IWebHostEnvironment _hostingEnvironment;

    // inject logger
    private readonly ILogger<UserRepository> _logger;
    public UserRepository(MainDbContext context, IEmailService emailService, IWebHostEnvironment hostingEnvironment, ILogger<UserRepository> logger)
    {
        _context = context;
        _emailService = emailService;
        _hostingEnvironment = hostingEnvironment;
        _logger = logger;
    }
    public async Task<IEnumerable<User>> GetUsers()
    {
        return await _context.Users.ToListAsync();
    }

    public async Task<User> GetUser(int id)
    {
        return await _context.Users.FindAsync(id);
    }


    public async Task<User> UpdateUser(UserRequest userRequest)
    {
        var user = await _context.Users.FindAsync(userRequest.Id);
        if (user == null)
        {
            return null;
        }

        _logger.LogInformation("changed for user {0},{1}", userRequest.ConfirmPassword, userRequest.Password);

        user.Name = userRequest.Name;
        user.IsAdmin = userRequest.IsAdmin;

        if (userRequest.ProfilePicture != null)
        {
            user.profilePicture = await uploadProfilePicture(userRequest.ProfilePicture);
        }

        if (await emailExists(userRequest.Email) && user.Email != userRequest.Email)
        {
            throw new Exception("Email already exists");
        }
        else if (user.Email != userRequest.Email)
        {
            user.Email = userRequest.Email;
            user.IsVerified = false;
            await sendVerificationEmail(user.Id);
        }

        if (userRequest.Password != null)
        {
            _logger.LogInformation("i guess you need to updooooooooot");
            user.Password = BCrypt.Net.BCrypt.HashPassword(userRequest.Password);            
        }

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

    public async Task sendVerificationEmail(int id)
    {


        var user = await _context.Users.FirstOrDefaultAsync(u => u.Id == id);
        if (user != null && user.IsVerified == false)
        {
            var emailVerifToken = new EmailVerifTokens
            {
                UserId = user.Id,
                Token = Guid.NewGuid().ToString(),
                ExpiryDate = DateTime.Now.AddMinutes(30)
            };
            _context.EmailVerifTokens.Add(emailVerifToken);
            await _context.SaveChangesAsync();

            // enocde token to url safe base64
            var encodedToken = HttpUtility.UrlEncode(emailVerifToken.Token);
            var url = $"http://localhost:4200/verify-email?token={encodedToken}";

            var mailData = new MailData
            {
                To = user.Email,
                Subject = "Verify your email",
                Body = $"Click on the link to verify your email: {url}"
            };

            _emailService.SendEmail(mailData);
        }
        else
        {
            throw new Exception("User not found or already verified");
        }
    }

    public async Task<User> verifyEmail(string token)
    {
        var emailVerifToken = await _context.EmailVerifTokens.FirstOrDefaultAsync(t => t.Token == token);
        if (emailVerifToken != null && emailVerifToken.ExpiryDate > DateTime.Now)
        {
            var user = await _context.Users.FirstOrDefaultAsync(u => u.Id == emailVerifToken.UserId);
            if (user != null)
            {
                user.IsVerified = true;
                _context.Users.Update(user);
                _context.EmailVerifTokens.Remove(emailVerifToken);
                await _context.SaveChangesAsync();
                return user;
            }
            else
            {
                throw new Exception("User not found");
            }
        }
        else
        {
            throw new Exception("Invalid token");
        }
    }

    public async Task forgotPassword(string email)
    {
        var user = await _context.Users.FirstOrDefaultAsync(u => u.Email == email);
        if (user != null && user.IsVerified == true)
        {
            var passwordResetToken = new PasswordResetTokens
            {
                UserId = user.Id,
                Token = Guid.NewGuid().ToString(),
                ExpiryDate = DateTime.Now.AddMinutes(30)
            };

            _context.PasswordResetTokens.Add(passwordResetToken);
            await _context.SaveChangesAsync();

            // enocde token to url safe base64
            var encodedToken = HttpUtility.UrlEncode(passwordResetToken.Token);
            var url = $"http://localhost:4200/reset-password?token={encodedToken}";

            var mailData = new MailData
            {
                To = user.Email,
                Subject = "Reset your password",
                Body = $"Click on the link to reset your password: {url}"
            };

            _emailService.SendEmail(mailData);
        }
        else
        {
            throw new Exception("User not found or not verified");
        }
    }

    public async Task resetPassword(string token, string password, string confirmPassword)
    {
        var passwordResetToken = await _context.PasswordResetTokens.FirstOrDefaultAsync(t => t.Token == token);
        if (passwordResetToken != null && passwordResetToken.ExpiryDate > DateTime.Now)
        {
            var user = await _context.Users.FirstOrDefaultAsync(u => u.Id == passwordResetToken.UserId);
            if (user != null)
            {
                if (password == confirmPassword)
                {
                    user.Password = BCrypt.Net.BCrypt.HashPassword(password);
                    _context.PasswordResetTokens.Remove(passwordResetToken);
                    await _context.SaveChangesAsync();
                }
                else
                {
                    throw new Exception("Passwords do not match");
                }
            }
            else
            {
                throw new Exception("User not found");
            }
        }
        else
        {
            throw new Exception("Invalid token");
        }
    }

    public async Task<string> uploadProfilePicture(IFormFile profilePicture)
    {
        var dbImgPath = "";
        if (profilePicture != null && profilePicture.Length > 0)
        {
            var imgsPath = Path.Combine(_hostingEnvironment.WebRootPath, "profile-images");
            if (!Directory.Exists(imgsPath))
            {
                Directory.CreateDirectory(imgsPath);
            }

            var fileName = Guid.NewGuid().ToString() + Path.GetExtension(profilePicture.FileName);
            var filePath = Path.Combine(_hostingEnvironment.WebRootPath, "profile-images", fileName);



            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                await profilePicture.CopyToAsync(stream);
            }

            dbImgPath = Path.Combine("profile-images", fileName);
        }
        return dbImgPath;
    }

    public async Task<bool> emailExists(string email)
    {
        return await _context.Users.AnyAsync(u => u.Email == email);
    }

    public async Task<IEnumerable<User>> search(string query)
    {
        var users = await _context.Users.Where(u => u.Name.Contains(query)).ToListAsync();
        return users;
    }
}