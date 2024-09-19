using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Colab.Requests
{
    public class LoginRequest
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }

    public class GoogleCredentials
    {
        [Required]
        public string credential { get; set; }
    }

}