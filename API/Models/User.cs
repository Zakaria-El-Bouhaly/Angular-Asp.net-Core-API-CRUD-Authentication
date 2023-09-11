using Newtonsoft.Json;

namespace Colab.Models;
public class User
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public bool IsVerified { get; set; }= false;

    public string profilePicture { get; set; }
    //  ignore password when serializing
    [JsonIgnore]
    public string Password { get; set; }
    public bool IsAdmin { get; set; }
    // user has many projects
    public virtual List<ProjectUser> Participations { get; set; }
    // user has many invitations
    public virtual List<ProjectUserInvitation> Invitations { get; set; }


}
