using Microsoft.AspNetCore.Mvc;
using Colab.Models;
using Microsoft.AspNetCore.Authorization;
using Colab.Requests;
using Colab.Services;
using Colab.Repositories;
using Microsoft.EntityFrameworkCore;

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
            try
            {

                return Ok(await _projectRepo.GetAllProjects());
            }
            catch (Exception e)
            {
                return BadRequest(new { errors = e.Message });
            }
        }

        [Authorize(Roles = "User,Admin")]
        [HttpGet("user/{id}")]
        public async Task<ActionResult<IEnumerable<Project>>> GetProjectsByUserId(int id)
        {
            try
            {
                return Ok(await _projectRepo.GetProjectsByUserId(id));
            }
            catch (Exception e)
            {
                return BadRequest(new { errors = e.Message });
            }
        }

        [Authorize(Roles = "User,Admin")]
        [HttpGet("{id}")]
        public async Task<ActionResult<Project>> GetProject(int id)
        {
            try
            {
                var project = await _projectRepo.GetProjectById(id);
                return Ok(project);
            }
            catch (Exception e)
            {
                return BadRequest(new { errors = e.Message });
            }
        }

        [Authorize(Roles = "User,Admin")]
        [HttpPost]
        public async Task<ActionResult<Project>> PostProject(ProjectRequest project)
        {
            try
            {
                var newProject = await _projectRepo.CreateProject(project);
                return CreatedAtAction("GetProject", new { id = newProject.Id }, newProject);
            }
            catch (Exception e)
            {
                return BadRequest(new { errors = e.Message });
            }
        }

        [Authorize(Roles = "User,Admin")]
        [HttpDelete("{id}")]
        public async Task<ActionResult<Project>> DeleteProject(int id)
        {
            try
            {
                var deletedProject = await _projectRepo.DeleteProject(id);
                return Ok(deletedProject);
            }
            catch (Exception e)
            {
                return BadRequest(new { errors = e.Message });
            }
        }

        [Authorize(Roles = "User,Admin")]
        [HttpPut("{id}")]
        public async Task<ActionResult<Project>> PutProject(ProjectRequest project)
        {
            try
            {
                var updatedProject = await _projectRepo.UpdateProject(project);
                return Ok(updatedProject);
            }
            catch (Exception e)
            {
                return BadRequest(new { errors = e.Message });
            }
        }

        [Authorize(Roles = "User,Admin")]
        [HttpPost("addUser")]
        public async Task<ActionResult<Project>> AddUserToProject(ProjectUserDto projectUser)
        {
            try
            {
                var updatedProject = await _projectRepo.AddUserToProject(projectUser);
                return Ok(updatedProject);
            }
            catch (DbUpdateException e)
            {
                return BadRequest(new { errors = "User already in project" });

            }

            catch (InvalidOperationException e)
            {
                return BadRequest(new { errors = "User already in project" });

            }

            catch (Exception e)
            {
                return BadRequest(new { errors = e.Message });
            }

        }

        [Authorize(Roles = "User,Admin")]
        [HttpPut("updateUser")]
        public async Task<ActionResult<ProjectUser>> UpdateUserInProject(ProjectUserDto projectUser)
        {
            try
            {
                var updatedProjectUser = await _projectRepo.UpdateUserInProject(projectUser);
                return Ok(updatedProjectUser);
            }
            catch (Exception e)
            {
                return BadRequest(new { errors = e.Message });
            }
        }

        [Authorize(Roles = "User,Admin")]
        [HttpPost("removeUser")]
        public async Task<ActionResult<Project>> RemoveUserFromProject(ProjectUserDto projectUser)
        {
            try
            {
                var updatedProject = await _projectRepo.RemoveUserFromProject(projectUser);
                return Ok(updatedProject);
            }
            catch (Exception e)
            {
                return BadRequest(new { errors = e.Message });
            }
        }

        [Authorize(Roles = "User,Admin")]
        [HttpGet("participations")]
        public async Task<ActionResult<IEnumerable<Project>>> GetParticipations()
        {
            try
            {
                return Ok(await _projectRepo.GetParticipations());
            }
            catch (Exception e)
            {
                return BadRequest(new { errors = e.Message });
            }
        }



    }
}
