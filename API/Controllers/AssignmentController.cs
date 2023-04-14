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

            return Ok(await _assignmentRepo.GetAssignments());
        }

        // GET: api/Assignment/5
        [Authorize(Roles = "User,Admin")]
        [HttpGet("{id}")]
        public async Task<ActionResult<Assignment>> GetAssignment(int id)
        {
            var assignment = await _assignmentRepo.GetAssignment(id);

            if (assignment == null)
            {
                return NotFound();
            }

            return Ok(assignment);
        }

        // PUT: api/Assignment/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [Authorize(Roles = "User,Admin")]
        [HttpPut]
        public async Task<IActionResult> PutAssignment(AssignmentRequest assignment)
        {
            var assignments = await _assignmentRepo.PutAssignment(assignment);
            if (assignments == null)
            {
                return NotFound();
            }
            return Ok(assignment);

        }

        // POST: api/Assignment
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [Authorize(Roles = "User,Admin")]
        [HttpPost]
        public async Task<ActionResult<Assignment>> PostAssignment(BaseAssignmentRequest assignment)
        {
            return Ok(await _assignmentRepo.PostAssignment(assignment));
        }

        // DELETE: api/Assignment/5

        [Authorize(Roles = "User,Admin")]
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAssignment(int id)
        {
            var assignments = await _assignmentRepo.DeleteAssignment(id);
            if (assignments == null)
            {
                return NotFound();
            }
            return Ok(new { message = "Assignment deleted" });
        }

        [Authorize(Roles = "User,Admin")]
        [HttpGet("usertasks/{id}")]
        public async Task<ActionResult<IEnumerable<Assignment>>> GetAssignmentsByUserProject(int id)
        {
            return Ok(await _assignmentRepo.GetAssignmentsByUserProject(id));
        }

    }
}
