namespace Colab.Domain.Models;

public class PasswordResetTokens
{
   public long Id { get; set; }
   public string Token { get; set; }
   public DateTime ExpiryDate { get; set; }
   public virtual User User { get; set; }
}