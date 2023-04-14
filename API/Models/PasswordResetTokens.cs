using System.ComponentModel.DataAnnotations.Schema;

namespace Colab.Models
{
   public class PasswordResetTokens
   {
       public int Id { get; set; }
       public string Token { get; set; }
       public DateTime ExpiryDate { get; set; }
       [ForeignKey("User")]
       public int UserId { get; set; }
       public User User { get; set; }
   }
}