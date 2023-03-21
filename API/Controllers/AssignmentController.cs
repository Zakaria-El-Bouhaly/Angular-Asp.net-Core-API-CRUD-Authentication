using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Colab.Models;
using Colab.Requests;

namespace Colab.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AssignmentController : ControllerBase
    {
        private readonly MainDbContext _context;

        public AssignmentController(MainDbContext context)
        {
            _context = context;
        }

        // GET: api/Assignment
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Assignment>>> GetAssignments()
        {
            if (_context.Assignments == null)
            {
                return NotFound();
            }
            return await _context.Assignments.ToListAsync();
        }

        // GET: api/Assignment/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Assignment>> GetAssignment(int id)
        {
            if (_context.Assignments == null)
            {
                return NotFound();
            }
            var assignment = await _context.Assignments.FindAsync(id);

            if (assignment == null)
            {
                return NotFound();
            }

            return assignment;
        }

        // PUT: api/Assignment/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut]
        public async Task<IActionResult> PutAssignment(AssignmentRequest assignment)
        {

            // update 
            var assignmentToUpdate = await _context.Assignments.FindAsync(assignment.Id);
            if (assignmentToUpdate == null)
            {
                return NotFound();
            }
            assignmentToUpdate.Title = assignment.Title;
            assignmentToUpdate.Description = assignment.Description;
            assignmentToUpdate.IsCompleted = assignment.IsCompleted;
            assignmentToUpdate.ProjectId = assignment.ProjectId;
            assignmentToUpdate.UpdatedAt = DateTime.Now;

            _context.Entry(assignmentToUpdate).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                // return error message if update fails
                return BadRequest(new { message = "Update failed" });

            }

            // return success message
            return Ok(assignmentToUpdate);
        }

        // POST: api/Assignment
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Assignment>> PostAssignment(BaseAssignmentRequest assignment)
        {
            if (_context.Assignments == null)
            {
                return Problem("Entity set 'MainDbContext.Assignments'  is null.");
            }

            var newAssignment = new Assignment
            {
                Title = assignment.Title,
                Description = assignment.Description,
                ProjectId = assignment.ProjectId,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
            };
            _context.Assignments.Add(newAssignment);
            await _context.SaveChangesAsync();

            return Ok(newAssignment);
        }

        // DELETE: api/Assignment/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAssignment(int id)
        {
            if (_context.Assignments == null)
            {
                return NotFound();
            }
            var assignment = await _context.Assignments.FindAsync(id);
            if (assignment == null)
            {
                return NotFound();
            }

            _context.Assignments.Remove(assignment);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AssignmentExists(int id)
        {
            return (_context.Assignments?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
