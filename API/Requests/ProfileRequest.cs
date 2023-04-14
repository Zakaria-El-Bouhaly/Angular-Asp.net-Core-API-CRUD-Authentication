using System.ComponentModel.DataAnnotations;
using Colab.Validators;

namespace Colab.Requests
{
    public class ProfileRequest
    {

        [Required]
        public string Name { get; set; }
        [MaxFileSize(1 * 1024 * 1024)]
        [AllowedExtensions(new string[] { ".jpg", ".png", ".jpeg" })]
        public IFormFile ProfilePicture { get; set; }



    }

    public class EmailRequest
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string CurrentPassword { get; set; }
    }

    public class PasswordRequest
    {
        [Required]
        public string CurrentPassword { get; set; }
        [Required]
        [MinLength(6)]
        public string NewPassword { get; set; }
        [Required]
        [Compare("NewPassword")]
        public string ConfirmPassword { get; set; }
    }


}