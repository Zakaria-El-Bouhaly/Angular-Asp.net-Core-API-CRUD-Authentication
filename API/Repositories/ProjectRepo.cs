using Colab.Models;
using Colab.Requests;
using Colab.Services;
using Microsoft.EntityFrameworkCore;

namespace Colab.Repositories
{
    public class ProjectRepo : IProjectRepo
    {
        private readonly MainDbContext _context;
        private readonly ITokenService _jwtService;

        public ProjectRepo(MainDbContext context, ITokenService jwtService)
        {
            _context = context;
            _jwtService = jwtService;
        }

        public async Task<IEnumerable<Project>> GetAllProjects()
        {
            return await _context.Projects.ToListAsync();
        }

        public async Task<IEnumerable<Project>> GetProjectsByUserId(int id)
        {
            var userId = _jwtService.getUserId();

            if (userId == id || _jwtService.isAdmin())
            {
                var projects = await _context.Projects
                    .Where(p => p.Participators.Any(u => u.UserId == id && u.IsOwner))
                    .ToListAsync();

                return projects;
            }
            throw new Exception("You are not authorized to view this user's projects");
        }

        public async Task<Project> GetProjectById(int id)
        {
            await hasAccessToPrjct(id);

            var project = await _context.Projects.Where(p => p.Id == id)
            .Include(p => p.Participators).ThenInclude(p => p.User)
            .Include(p => p.Invitations).ThenInclude(p => p.User)
            .Include(p => p.Assignments).FirstOrDefaultAsync();

            return project;
        }

        public async Task<Project> CreateProject(ProjectRequest project)
        {

            var newProject = new Project
            {
                Title = project.Title,
                Description = project.Description,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
            };

            _context.Projects.Add(newProject);

            await _context.SaveChangesAsync();

            var userId = _jwtService.getUserId();

            _context.Set<ProjectUser>().Add(new ProjectUser
            {
                ProjectId = newProject.Id,
                UserId = userId,
                IsOwner = true
            });


            await _context.SaveChangesAsync();

            return newProject;

        }

        public async Task<Project> UpdateProject(ProjectRequest project)
        {
            var userId = _jwtService.getUserId();
            await hasAccessToPrjct(project.Id);

            var projectToUpdate = await _context.Projects.Where(p => p.Id == project.Id).FirstOrDefaultAsync();

            if (projectToUpdate != null)
            {
                projectToUpdate.Title = project.Title;
                projectToUpdate.Description = project.Description;
                projectToUpdate.UpdatedAt = DateTime.Now;

                await _context.SaveChangesAsync();
                return projectToUpdate;
            }
            else
            {
                return null;
            }
        }

        public async Task<Project> DeleteProject(int id)
        {
            var userId = _jwtService.getUserId();
            await hasAccessToPrjct(id);

            var project = await _context.Projects.Where(p => p.Id == id).FirstOrDefaultAsync();

            if (project != null)
            {
                _context.Projects.Remove(project);
                await _context.SaveChangesAsync();
                return project;
            }

            return null;
        }

        public async Task<ProjectUserInvitation> AddUserToProject(ProjectUserDto projectUser)
        {
            var userId = _jwtService.getUserId();
            await hasAccessToPrjct(projectUser.ProjectId);

            // check if invitation already exists
            var invitationExists = await _context.ProjectUserInvitations
            .Where(p => p.ProjectId == projectUser.ProjectId && p.UserId == projectUser.UserId).AnyAsync();

            var alreadyInProject = await _context.Set<ProjectUser>().Where(p => p.ProjectId == projectUser.ProjectId && p.UserId == projectUser.UserId).AnyAsync();

            if (invitationExists || alreadyInProject)
                throw new Exception("User already invited or in project");


            var invitation = new ProjectUserInvitation
            {
                ProjectId = projectUser.ProjectId,
                UserId = projectUser.UserId,
                IsOwner = projectUser.IsOwner,
                CreatedAt = DateTime.Now,
            };

            await _context.ProjectUserInvitations.AddAsync(invitation);

            await _context.SaveChangesAsync();

            return invitation;
        }

        public async Task<ProjectUser> UpdateUserInProject(ProjectUserDto projectUser)
        {
            var userId = _jwtService.getUserId();
            await hasAccessToPrjct(projectUser.ProjectId);

            if (projectUser.UserId == userId)
                throw new Exception("Cannot change your own role");

            var user = _context.Set<ProjectUser>().Where(p => p.ProjectId == projectUser.ProjectId && p.UserId == projectUser.UserId).FirstOrDefault();
            user.IsOwner = projectUser.IsOwner;

            await _context.SaveChangesAsync();
            return user;

        }

        public async Task<ProjectUser> RemoveUserFromProject(ProjectUserDto projectUser)
        {
            var userId = _jwtService.getUserId();
            await hasAccessToPrjct(projectUser.ProjectId);

            if (projectUser.UserId == userId)
                throw new Exception("Cannot remove yourself from project");

            var deletedProjectUser = _context.Set<ProjectUser>().Where(p => p.ProjectId == projectUser.ProjectId && p.UserId == projectUser.UserId).FirstOrDefault();
            _context.Set<ProjectUser>().Remove(deletedProjectUser);

            await _context.SaveChangesAsync();
            return deletedProjectUser;

        }

        public async Task<IEnumerable<Project>> GetParticipations()
        {
            var userId = _jwtService.getUserId();
            return await _context.Projects.Where(p => p.Participators.Any(u => u.UserId == userId)).ToListAsync();
        }

        private async Task<bool> hasAccessToPrjct(int projectId)
        {
            bool isAdmin = _jwtService.isAdmin();
            if (isAdmin)
                return true;

            var userId = _jwtService.getUserId();

            var isOwner = await _context.Projects.Where(p => p.Id == projectId && p.Participators.Any(u => u.UserId == userId && u.IsOwner)).AnyAsync();
            if (isOwner)
                return true;

            throw new UnauthorizedAccessException("project not found");
        }
    }
}