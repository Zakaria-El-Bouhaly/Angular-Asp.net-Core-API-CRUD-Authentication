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
}

public class AssignmentRequest : BaseAssignmentRequest
{
    [Required]
    public int Id { get; set; }
    [Required]
    public bool IsCompleted { get; set; }
}

