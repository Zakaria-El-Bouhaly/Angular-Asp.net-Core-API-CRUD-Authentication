namespace Colab.Domain.Models
{
    public class ProjectUser
    {
      
        public Guid ProjectId { get; set; }
        public virtual Project Project { get; set; }

      
        public Guid UserId { get; set; }
        public virtual User User { get; set; }

        public bool IsOwner { get; set; }
    }
}