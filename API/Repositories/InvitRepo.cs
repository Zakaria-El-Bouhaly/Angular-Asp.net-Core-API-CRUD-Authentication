using Colab.Models;
using Colab.Requests;
using Colab.Services;
using Microsoft.EntityFrameworkCore;

namespace Colab.Repositories;
public class InvitRepo : IInvitationRepo
{
    private readonly MainDbContext _context;
    private readonly ITokenService _tokenService;

    public InvitRepo(MainDbContext context, ITokenService tokenService)
    {
        _context = context;
        _tokenService = tokenService;
    }

    public async Task<ProjectUserInvitation> AcceptInvitation(int id)
    {
        var userId = _tokenService.getUserId();

        var invitation = _context.ProjectUserInvitations
        .FirstOrDefault(i => i.Id == id && i.UserId == userId);

        if (invitation == null)
        {
            throw new Exception("Invitation not found");
        }

        // create new project user
        var projectUser = new ProjectUser
        {
            ProjectId = invitation.ProjectId,
            UserId = userId,
            IsOwner = invitation.IsOwner
        };

        _context.ProjectUserInvitations.Remove(invitation);

        await _context.Set<ProjectUser>().AddAsync(projectUser);

        await _context.SaveChangesAsync();

        return invitation;

    }

    public async Task<ProjectUserInvitation> RejectInvitation(int id)
    {
        var userId = _tokenService.getUserId();

        var invitation = _context.ProjectUserInvitations
        .FirstOrDefault(i => i.Id == id && i.UserId == userId);

        if (invitation == null)
        {
            throw new Exception("Invitation not found");
        }



        _context.ProjectUserInvitations.Remove(invitation);

        await _context.SaveChangesAsync();

        return invitation;

    }




    public async Task<IEnumerable<ProjectUserInvitation>> GetUserInvitation()
    {
        // get user id from token
        var userId = _tokenService.getUserId();
        // get invitation from db
        var invitations = await _context.ProjectUserInvitations.Include(i => i.Project)
        .Where(i => i.UserId == userId).ToListAsync();
        return invitations;
    }
}