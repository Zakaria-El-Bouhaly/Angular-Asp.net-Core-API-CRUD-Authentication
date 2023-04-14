using System.ComponentModel.DataAnnotations.Schema;

namespace Colab.Models
{
    public class EmailVerifTokens
    {
        public int Id { get; set; }
        public string Token { get; set; }
        public DateTime ExpiryDate { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }
        public virtual User User { get; set; }
    }
}