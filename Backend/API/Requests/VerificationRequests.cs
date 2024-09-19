using System.ComponentModel.DataAnnotations;

namespace Colab.Requests
{
    public class VerificationRequest
    {
        [Required]
        public string Token { get; set; }
    }

    public class ForgotPasswordRequest
    {
        [Required]
        public string Email { get; set; }
    }

    public class ResetPasswordRequest
    {
        [Required]
        public string Token { get; set; }
        [Required]
        [MinLength(6)]
        public string Password { get; set; }
        [Compare("Password")]
        public string ConfirmPassword { get; set; }
    }
}