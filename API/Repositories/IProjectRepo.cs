using Colab.Models;
using Colab.Requests;

namespace Colab.Repositories
{
    public interface IProjectRepo
    {
        Task<IEnumerable<Project>> GetAllProjects();
        Task<IEnumerable<Project>> GetProjectsByUserId(int id);
        Task<Project> GetProjectById(int id);
        Task<Project> CreateProject(ProjectRequest project);
        Task<Project> UpdateProject(ProjectRequest project);
        Task<Project> DeleteProject(int id);
        Task<ProjectUserInvitation> AddUserToProject(ProjectUserDto projectUser);
        Task<ProjectUser> UpdateUserInProject(ProjectUserDto projectUser);
        Task<ProjectUser> RemoveUserFromProject(ProjectUserDto projectUser);
        Task<IEnumerable<Project>> GetParticipations(); 
    }
}