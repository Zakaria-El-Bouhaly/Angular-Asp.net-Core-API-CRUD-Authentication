using Microsoft.AspNetCore.Mvc;
using Colab.Models;
using Colab.Requests;
using Colab.Repositories;
using Microsoft.AspNetCore.Authorization;

namespace Colab.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AssignmentController : ControllerBase
    {

        private readonly IAssignmentRepo _assignmentRepo;

        public AssignmentController(IAssignmentRepo assignmentRepo)
        {

            _assignmentRepo = assignmentRepo;
        }

        // GET: api/Assignment
        [HttpGet]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult<IEnumerable<Assignment>>> GetAssignments()
        {
            try
            {
                return Ok(await _assignmentRepo.GetAssignments());
            }
            catch (Exception e)
            {
                return BadRequest(new { errors = e.Message });
            }
        }

        // GET: api/Assignment/5
        [Authorize(Roles = "User,Admin")]
        [HttpGet("{id}")]
        public async Task<ActionResult<Assignment>> GetAssignment(int id)
        {
            try
            {
                var assignment = await _assignmentRepo.GetAssignment(id);
                return Ok(assignment);
            }
            catch (Exception e)
            {
                return BadRequest(new { errors = e.Message });
            }
        }

        [Authorize(Roles = "User,Admin")]
        [HttpPut]
        public async Task<IActionResult> PutAssignment(AssignmentRequest assignment)
        {
            try
            {
                var assignments = await _assignmentRepo.PutAssignment(assignment);

                return Ok(assignment);
            }
            catch (Exception e)
            {
                return BadRequest(new { errors = e.Message });
            }

        }

        [Authorize(Roles = "User,Admin")]
        [HttpPost]
        public async Task<ActionResult<Assignment>> PostAssignment(BaseAssignmentRequest assignment)
        {
            try
            {
                var newAsg = await _assignmentRepo.PostAssignment(assignment);
                return Ok(newAsg);
            }
            catch (Exception e)
            {
                return BadRequest(new { errors = e.Message });
            }

        }


        [Authorize(Roles = "User,Admin")]
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAssignment(int id)
        {
            try
            {
                var assignments = await _assignmentRepo.DeleteAssignment(id);
                return Ok(new { message = "Assignment deleted" });
            }
            catch (Exception e)
            {
                return BadRequest(new { errors = e.Message });
            }
        }

        [Authorize(Roles = "User,Admin")]
        [HttpGet("usertasks/{id}")]
        public async Task<ActionResult<IEnumerable<Assignment>>> GetAssignmentsByUserProject(int id)
        {
            try
            {
                return Ok(await _assignmentRepo.GetAssignmentsByUserProject(id));
            }
            catch (Exception e)
            {
                return BadRequest(new { errors = e.Message });
            }
        }

    }
}
