using Colab.Models;
using Colab.Requests;
using Colab.Services;
using Microsoft.EntityFrameworkCore;

namespace Colab.Repositories;

public class AssignmentRepo : IAssignmentRepo
{

    private readonly MainDbContext _context;
    private readonly ITokenService _tokenService;
    public AssignmentRepo(MainDbContext context, ITokenService tokenService)
    {
        _context = context;
        _tokenService = tokenService;
    }

    public async Task<Assignment> DeleteAssignment(int id)
    {
        var assignment = await _context.Assignments.FindAsync(id);
        if (assignment == null)
        {
            return null;
        }

        _context.Assignments.Remove(assignment);
        await _context.SaveChangesAsync();

        return assignment;
    }

    public async Task<Assignment> GetAssignment(int id)
    {
        return await _context.Assignments.FindAsync(id);
    }

    public async Task<IEnumerable<Assignment>> GetAssignments()
    {
        return await _context.Assignments.ToListAsync();
    }

    public async Task<IEnumerable<Assignment>> GetAssignmentsByUserProject(int id)
    {
        var userId = _tokenService.getUserId();
        return await _context.Assignments.Where(a => a.UserId == userId && a.ProjectId == id).ToListAsync();
    }

    public async Task<Assignment> PostAssignment(BaseAssignmentRequest assignment)
    {
        var newAssignment = new Assignment
        {
            Title = assignment.Title,
            Description = assignment.Description,
            ProjectId = assignment.ProjectId,
            UserId = assignment.UserId,
            state = assignment.state,
            CreatedAt = DateTime.Now,
            UpdatedAt = DateTime.Now,
        };
        _context.Assignments.Add(newAssignment);
        await _context.SaveChangesAsync();

        return newAssignment;
    }

    public async Task<Assignment> PutAssignment(AssignmentRequest assignment)
    {

        // update 
        var assignmentToUpdate = await _context.Assignments.FindAsync(assignment.Id);

        if (assignmentToUpdate == null)
        {
            return null;
        }

        assignmentToUpdate.Title = assignment.Title;
        assignmentToUpdate.Description = assignment.Description;
        assignmentToUpdate.state = assignment.state;
        assignmentToUpdate.ProjectId = assignment.ProjectId;
        assignmentToUpdate.UserId = assignment.UserId;
        assignmentToUpdate.UpdatedAt = DateTime.Now;
        _context.Entry(assignmentToUpdate).State = EntityState.Modified;


        await _context.SaveChangesAsync();

        return assignmentToUpdate;
    }
}