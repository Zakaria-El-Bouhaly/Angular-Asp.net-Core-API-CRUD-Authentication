namespace Colab.Domain.Models;
public class ProjectUserInvitation
{
    public int Id { get; set; }


    public Guid ProjectId { get; set; }
    public virtual Project Project { get; set; }


    public Guid UserId { get; set; }
    public virtual User User { get; set; }

    public bool IsOwner { get; set; }
    public DateTime CreatedAt { get; set; }
}