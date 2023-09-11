using Colab.Models;
using Colab.Requests;

namespace Colab.Repositories;
public interface IInvitationRepo
{
    Task<ProjectUserInvitation> AcceptInvitation(int id);
    Task<ProjectUserInvitation> RejectInvitation(int id);
    Task<IEnumerable<ProjectUserInvitation>> GetUserInvitation(); 

}