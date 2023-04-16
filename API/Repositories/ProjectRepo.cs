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
            return null;



        }

        public async Task<Project> GetProjectById(int id)
        {
            var userId = _jwtService.getUserId();
            var project = await hasAccess(userId, id);
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

            // get NameIdentifier from token
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
            var projectToUpdate = await hasAccess(userId, project.Id);

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
            var project = await hasAccess(userId, id);

            if (project != null)
            {
                _context.Projects.Remove(project);
                await _context.SaveChangesAsync();
                return project;
            }

            return null;

        }

        public async Task<ProjectUser> AddUserToProject(ProjectUserDto projectUser)
        {
            var userId = _jwtService.getUserId();
            var project = await hasAccess(userId, projectUser.ProjectId);

            if (project != null)
            {

                var newProjectUser = new ProjectUser
                {
                    ProjectId = projectUser.ProjectId,
                    UserId = projectUser.UserId,
                    IsOwner = projectUser.IsOwner
                };

                _context.Set<ProjectUser>().Add(newProjectUser);

                await _context.SaveChangesAsync();

                newProjectUser = _context.Set<ProjectUser>().Where(p => p.ProjectId == projectUser.ProjectId && p.UserId == projectUser.UserId).Include(p => p.User).FirstOrDefault();

                return newProjectUser;
            }
            else
            {
                return null;
            }
        }

        public async Task<ProjectUser> UpdateUserInProject(ProjectUserDto projectUser)
        {
            var userId = _jwtService.getUserId();
            var project = await hasAccess(userId, projectUser.ProjectId);

            if (project != null)
            {
                var user = _context.Set<ProjectUser>().Where(p => p.ProjectId == projectUser.ProjectId && p.UserId == projectUser.UserId).FirstOrDefault();
                user.IsOwner = projectUser.IsOwner;
                await _context.SaveChangesAsync();
                return user;
            }
            else
            {
                return null;
            }
        }

        public async Task<ProjectUser> RemoveUserFromProject(ProjectUserDto projectUser)
        {
            var userId = _jwtService.getUserId();
            var project = hasAccess(userId, projectUser.ProjectId);

            if (project != null)
            {
                var deletedProjectUser = _context.Set<ProjectUser>().Where(p => p.ProjectId == projectUser.ProjectId && p.UserId == projectUser.UserId).FirstOrDefault();
                _context.Set<ProjectUser>().Remove(deletedProjectUser);

                await _context.SaveChangesAsync();
                return deletedProjectUser;
            }
            else
            {
                return null;
            }
        }

        public async Task<IEnumerable<Project>> GetParticipations()
        {
            var userId = _jwtService.getUserId();
            return await _context.Projects.Where(p => p.Participators.Any(u => u.UserId == userId)).ToListAsync();
        }


        public async Task<Project> hasAccess(int userId, int projectId)
        {
            bool isAdmin = _jwtService.isAdmin();

          

            if (isAdmin)
            {

                return await _context.Projects.Where(p => p.Id == projectId).Include(p => p.Participators).ThenInclude(p => p.User).Include(p => p.Assignments).FirstOrDefaultAsync();
            }

            var project = await _context.Projects.Where(p => p.Id == projectId && p.Participators.Any(u => u.UserId == userId && u.IsOwner)).Include(p => p.Participators).ThenInclude(p => p.User).Include(p => p.Assignments).FirstOrDefaultAsync();
            return project;
        }
    }
}