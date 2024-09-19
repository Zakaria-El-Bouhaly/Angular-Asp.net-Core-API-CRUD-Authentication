namespace Colab.Domain.Models;

public class Assignment
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public int state { get; set; }

    //assignment has one project
    public virtual Project Project { get; set; }
 
    public virtual User User { get; set; }


}






