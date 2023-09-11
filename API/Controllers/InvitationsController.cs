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
    public class InvitationsController : ControllerBase
    {

        private readonly IInvitationRepo _invitationRepo;

        public InvitationsController(IInvitationRepo invitationRepo)
        {
            _invitationRepo = invitationRepo;
        }


        [Authorize(Roles = "Admin,User")]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProjectUserInvitation>>> GetUserInvit()
        {
            try
            {
                var invits = await _invitationRepo.GetUserInvitation();
                return Ok(invits);
            }
            catch (Exception e)
            {
                return BadRequest(new { errors = e.Message });
            }
        }

        [Authorize(Roles = "Admin,User")]
        [HttpDelete("accept/{id}")]

        public async Task<ActionResult<ProjectUserInvitation>> AcceptInvit(int id)
        {
            try
            {
                var invits = await _invitationRepo.AcceptInvitation(id);
                return Ok(invits);
            }
            catch (Exception e)
            {
                return BadRequest(new { errors = e.Message });
            }
        }

        [Authorize(Roles = "Admin,User")]
        [HttpDelete("reject/{id}")]

        public async Task<ActionResult<ProjectUserInvitation>> RejectInvit(int id)
        {
            try
            {
                var invits = await _invitationRepo.RejectInvitation(id);
                return Ok(invits);
            }
            catch (Exception e)
            {
                return BadRequest(new { errors = e.Message });
            }
        }



    }
}
