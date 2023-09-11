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
    public class ProfileController : ControllerBase
    {

        private readonly IProfileRepo _profileRepo;

        public ProfileController(IProfileRepo profileRepo)
        {
            _profileRepo = profileRepo;
        }

        [Authorize(Roles = "Admin,User")]
        [HttpGet]
        public async Task<ActionResult<User>> GetProfile()
        {
            var profile = await _profileRepo.GetProfile();

            return Ok(profile);
        }

        [Authorize(Roles = "Admin,User")]
        [HttpPut]
        public async Task<ActionResult<User>> UpdateProfile([FromForm] ProfileRequest user)
        {
            var profile = await _profileRepo.UpdateProfile(user);
            return Ok(profile);
        }

        [Authorize(Roles = "Admin,User")]
        [HttpPut("email")]
        public async Task<ActionResult<User>> UpdateEmail([FromBody] EmailRequest emailRequest)
        {
            try
            {
                var profile = await _profileRepo.UpdateEmail(emailRequest,Request.Headers["Origin"]);
                return Ok(profile);
            }
            catch (Exception e)
            {
                return BadRequest(new { errors = e.Message });
            }
        }

        [Authorize(Roles = "Admin,User")]
        [HttpPut("password")]
        public async Task<ActionResult<User>> UpdatePassword([FromBody] PasswordRequest passwordRequest)
        {
            try
            {
                await _profileRepo.UpdatePassword(passwordRequest);
                return Ok(new { message = "Password updated successfully" });
            }
            catch (Exception e)
            {                
                return BadRequest(new { errors = new { CurrentPassword = e.Message } });
            }
        }
        
    }
}
