//import attributes
using System.ComponentModel.DataAnnotations.Schema;
namespace Colab.Models
{
    public class Project
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        // project has many assignments
        public virtual List<Assignment> Assignments { get; set; }      
        // project has many users
        public virtual List<ProjectUser> Participators { get; set; }
        // project has many invitations
        public virtual List<ProjectUserInvitation> Invitations { get; set; }


    }
}