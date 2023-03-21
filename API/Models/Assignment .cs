using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Colab.Models;

public class Assignment
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public bool IsCompleted { get; set; }

    //assignment has one project

    [ForeignKey("Project")]
    public int ProjectId { get; set; }
    public virtual Project Project { get; set; }

}






