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
    public int state { get; set; }

    //assignment has one project

    [ForeignKey("Project")]
    public int ProjectId { get; set; }
    public virtual Project Project { get; set; }

    [ForeignKey("User")]
    public int UserId { get; set; }    
    public virtual User User { get; set; }


}






