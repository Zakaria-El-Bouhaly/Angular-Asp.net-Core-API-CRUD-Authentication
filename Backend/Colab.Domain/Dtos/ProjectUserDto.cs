using System.ComponentModel.DataAnnotations;

namespace Colab.Domain.Dtos;
public class ProjectUserDto
{
    [Required]
    public Guid ProjectId { get; set; }
    [Required]
    public Guid UserId { get; set; }
    [Required]
    public bool IsOwner { get; set; }

}