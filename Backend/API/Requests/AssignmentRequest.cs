using System.ComponentModel.DataAnnotations;
namespace Colab.Requests;
public class BaseAssignmentRequest
{
    [Required]
    public string Title { get; set; }
    [Required]
    public string Description { get; set; }

    [Required]
    public int ProjectId { get; set; }

    [Required]
    public int UserId { get; set; }

    [Required]
    [Range(0, 2)]
    public int state { get; set; }
}

public class AssignmentRequest : BaseAssignmentRequest
{
    [Required]
    public int Id { get; set; }

}

