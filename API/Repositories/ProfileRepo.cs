using Colab.Models;
using Colab.Requests;
using Colab.Services;
using Microsoft.EntityFrameworkCore;


namespace Colab.Repositories
{
    public class ProfileRepo : IProfileRepo
    {
        private readonly MainDbContext _context;
        private readonly ITokenService _tokenService;
        private readonly IWebHostEnvironment _hostingEnvironment;
        private readonly IEmailService _emailService;
        private readonly IUserRepository _userRepository;

        public ProfileRepo(MainDbContext context, ITokenService tokenService,
         IWebHostEnvironment hostingEnvironment, IEmailService emailService, IUserRepository userRepository)
        {
            _context = context;
            _tokenService = tokenService;
            _hostingEnvironment = hostingEnvironment;
            _emailService = emailService;
            _userRepository = userRepository;
        }

        public async Task<User> GetProfile()
        {

            var profile = await _context.Users.FirstOrDefaultAsync(x => x.Id == _tokenService.getUserId());
            return profile;
        }

        public async Task<User> UpdateProfile(ProfileRequest profileRequest)
        {
            User profile = await _context.Users.FirstOrDefaultAsync(x => x.Id == _tokenService.getUserId());
            if (profile != null)
            {
                profile.Name = profileRequest.Name;


                if (profileRequest.ProfilePicture != null && profileRequest.ProfilePicture.Length > 0)
                {
                    var imgsPath = Path.Combine(_hostingEnvironment.WebRootPath, "profile-images");
                    if (!Directory.Exists(imgsPath))
                    {
                        Directory.CreateDirectory(imgsPath);
                    }

                    var fileName = Guid.NewGuid().ToString() + Path.GetExtension(profileRequest.ProfilePicture.FileName);
                    var filePath = Path.Combine(_hostingEnvironment.WebRootPath, "profile-images", fileName);



                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        await profileRequest.ProfilePicture.CopyToAsync(stream);
                    }

                    profile.profilePicture = Path.Combine("profile-images", fileName);
                }
                await _context.SaveChangesAsync();
            }
            return profile;
        }

        public async Task<User> UpdateEmail(EmailRequest emailRequest, string origin)
        {
            User profile = await _context.Users.FirstOrDefaultAsync(x => x.Id == _tokenService.getUserId());

            if (profile != null)
            {
                // check if current password is correct
                if (BCrypt.Net.BCrypt.Verify(emailRequest.CurrentPassword, profile.Password))
                {
                    // check if email is already taken
                    var emailExists = await _context.Users.AnyAsync(x => x.Email == emailRequest.Email);

                    if (emailExists)
                    {
                        throw new Exception("Email already exists");
                    }
                    profile.Email = emailRequest.Email;
                    profile.IsVerified = false;
                    await _context.SaveChangesAsync();
                    // send verification email
                    await _userRepository.sendVerificationEmail(_tokenService.getUserId(), origin);
                }
                else
                {
                    throw new Exception("Current password is incorrect");
                }
            }

            return profile;
        }

        public async Task UpdatePassword(PasswordRequest passwordRequest)
        {

            var profile = await _context.Users.FirstOrDefaultAsync(x => x.Id == _tokenService.getUserId());
            if (profile != null)
            {
                // check if current password is correct
                if (BCrypt.Net.BCrypt.Verify(passwordRequest.CurrentPassword, profile.Password))
                {
                    profile.Password = BCrypt.Net.BCrypt.HashPassword(passwordRequest.NewPassword);
                    _context.SaveChanges();
                }
                else
                {
                    throw new Exception("Current password is incorrect");
                }
            }
        }
    }




}