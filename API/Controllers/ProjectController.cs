using Microsoft.AspNetCore.Mvc;
using Colab.Models;
using Microsoft.AspNetCore.Authorization;
using Colab.Requests;
using Colab.Services;
using Colab.Repositories;

namespace Colab.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectController : ControllerBase
    {
        private readonly IProjectRepo _projectRepo;

        public ProjectController(IProjectRepo projectRepo, ITokenService jwtService)
        {
            _projectRepo = projectRepo;

        }

        // GET: api/Project
        [Authorize(Roles = "Admin")]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Project>>> GetProjects()
        {

            return Ok(await _projectRepo.GetAllProjects());
        }

        [Authorize(Roles = "User,Admin")]
        [HttpGet("user/{id}")]
        public async Task<ActionResult<IEnumerable<Project>>> GetProjectsByUserId(int id)
        {
            return Ok(await _projectRepo.GetProjectsByUserId(id));
        }




        [Authorize(Roles = "User,Admin")]
        [HttpGet("{id}")]
        public async Task<ActionResult<Project>> GetProject(int id)
        {
            var project = await _projectRepo.GetProjectById(id);
            if (project == null)
            {
                return NotFound(new { message = "Project not found" });
            }
            return Ok(project);
        }

        [Authorize(Roles = "User,Admin")]
        [HttpPost]
        public async Task<ActionResult<Project>> PostProject(ProjectRequest project)
        {
            var newProject = await _projectRepo.CreateProject(project);
            if (newProject.Id == 0)
            {
                return BadRequest(new { message = "Project creation failed" });
            }

            return CreatedAtAction("GetProject", new { id = newProject.Id }, newProject);
        }

        [Authorize(Roles = "User,Admin")]
        [HttpDelete("{id}")]
        public async Task<ActionResult<Project>> DeleteProject(int id)
        {
            var deletedProject = await _projectRepo.DeleteProject(id);
            if (deletedProject == null)
            {
                return BadRequest(new { message = "Project deletion failed" });
            }
            return Ok(deletedProject);
        }

        [Authorize(Roles = "User,Admin")]
        [HttpPut("{id}")]
        public async Task<ActionResult<Project>> PutProject(ProjectRequest project)
        {
            var updatedProject = await _projectRepo.UpdateProject(project);
            if (updatedProject == null)
            {
                return BadRequest(new { message = "Project update failed" });
            }
            return Ok(updatedProject);
        }

        [Authorize(Roles = "User,Admin")]
        [HttpPost("addUser")]
        public async Task<ActionResult<Project>> AddUserToProject(ProjectUserDto projectUser)
        {
            var updatedProject = await _projectRepo.AddUserToProject(projectUser);
            if (updatedProject == null)
            {
                return BadRequest(new { message = "User could not be added to project" });
            }
            return Ok(updatedProject);
        }

        [Authorize(Roles = "User,Admin")]
        [HttpPut("updateUser")]
        public async Task<ActionResult<ProjectUser>> UpdateUserInProject(ProjectUserDto projectUser)
        {
            var updatedProjectUser = await _projectRepo.UpdateUserInProject(projectUser);
            if (updatedProjectUser == null)
            {
                return BadRequest(new { message = "User could not be updated in project" });
            }
            return Ok(updatedProjectUser);
        }

        [Authorize(Roles = "User,Admin")]
        [HttpPost("removeUser")]
        public async Task<ActionResult<Project>> RemoveUserFromProject(ProjectUserDto projectUser)
        {
            var updatedProject = await _projectRepo.RemoveUserFromProject(projectUser);
            if (updatedProject == null)
            {
                return BadRequest(new { message = "User could not be removed from project" });
            }
            return Ok(updatedProject);
        }





    }
}
