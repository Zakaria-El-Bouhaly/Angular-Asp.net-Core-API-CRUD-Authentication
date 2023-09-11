using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Colab.Models;
public class ProjectUserInvitation
{
    public int Id { get; set; }

    [Required]
    [ForeignKey("Project")]
    public int ProjectId { get; set; }
    public Project Project { get; set; }

    [ForeignKey("User")]
    public int UserId { get; set; }
    public User User { get; set; }

    public bool IsOwner { get; set; }
    public DateTime CreatedAt { get; set; }
}