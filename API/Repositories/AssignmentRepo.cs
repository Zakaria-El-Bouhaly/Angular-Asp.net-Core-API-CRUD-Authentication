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


        await hasAccessToAsg(id);

        var assignment = await _context.Assignments.FindAsync(id);

        _context.Assignments.Remove(assignment);
        await _context.SaveChangesAsync();

        return assignment;
    }

    public async Task<Assignment?> GetAssignment(int id)
    {


        var hasAccess = await hasAccessToAsg(id);

        var assignment = await _context.Assignments.Include(a => a.Project).Include(a => a.User).FirstOrDefaultAsync(a => a.Id == id);

        return assignment;
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

    public async Task<Assignment?> PostAssignment(BaseAssignmentRequest assignment)
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
        var isMember = await _context.Projects.FirstOrDefaultAsync(p => p.Id == assignment.ProjectId && p.Participators.Any(u => u.UserId == assignment.UserId)) != null;
        if (!isMember)
            throw new UnauthorizedAccessException("user is not a member of this project");

        _context.Assignments.Add(newAssignment);
        await _context.SaveChangesAsync();

        return await GetAssignment(newAssignment.Id);
    }

    public async Task<Assignment> PutAssignment(AssignmentRequest assignment)
    {

        // update 
        var assignmentToUpdate = await GetAssignment(assignment.Id);

        if (assignmentToUpdate == null)
            throw new Exception("assignment not found");

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


    private async Task<bool> hasAccessToAsg(int asgId)
    {
        var userId = _tokenService.getUserId();

        var isAdmin = _tokenService.isAdmin();
        if (isAdmin)
        {
            return true;
        }
        var asg = await _context.Assignments.AnyAsync(a => a.Id == asgId && a.UserId == userId);

        if (asg)
            return true;

        var isOwner = await _context.Assignments.AnyAsync(a => a.Id == asgId && a.Project.Participators.Any(u => u.UserId == userId && u.IsOwner));
        if (isOwner)
            return true;

        throw new UnauthorizedAccessException("assignment not found");

    }


}