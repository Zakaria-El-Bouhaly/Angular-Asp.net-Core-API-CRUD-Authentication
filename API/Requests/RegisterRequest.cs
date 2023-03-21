using System.ComponentModel.DataAnnotations;

namespace Colab.Requests
{
    public class RegisterRequest
    {
        [Required]
        public string Name { get; set; }
        [Required]
        [EmailAddress]        
        public string Email { get; set; }
        [Required]
        [MinLength(6)]
        public string Password { get; set; }
        // password confirmation
        [Required]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }        

    }

}