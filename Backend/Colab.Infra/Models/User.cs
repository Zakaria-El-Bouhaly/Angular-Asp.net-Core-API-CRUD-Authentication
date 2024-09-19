using Microsoft.AspNetCore.Identity;
using Newtonsoft.Json;

namespace Colab.Domain.Models;
public class User  : IdentityUser<Guid>
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public bool IsVerified { get; set; }= false;

    public string profilePicture { get; set; }
    [JsonIgnore]
       
    public string Password { get; set; }    
    // user has many projects
    public virtual List<ProjectUser> Participations { get; set; }
    // user has many invitations
    public virtual List<ProjectUserInvitation> Invitations { get; set; }

    public virtual Role Role { get; set; }


}
