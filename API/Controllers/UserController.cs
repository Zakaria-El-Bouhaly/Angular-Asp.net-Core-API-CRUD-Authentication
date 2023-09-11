using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Colab.Models;
using Microsoft.AspNetCore.Authorization;
using Colab.Repositories;
using Colab.Services;
using Colab.Requests;

namespace Colab.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepository;
        private readonly ITokenService _tokenService;
        public UserController(IUserRepository userRpository, ITokenService tokenService)
        {
            _userRepository = userRpository;
            _tokenService = tokenService;
        }


        // GET: api/User
        [Authorize(Roles = "Admin")]
        [HttpGet]

        public async Task<ActionResult<IEnumerable<User>>> GetUsers()
        {
            var users = await _userRepository.GetUsers();
            return Ok(users);
        }

        // GET: api/User/5

        [Authorize(Roles = "Admin")]
        [HttpGet("{id}")]
        public async Task<ActionResult<User>> GetUser(int id)
        {


            var user = await _userRepository.GetUser(id);

            if (user == null)
            {
                return NotFound();
            }

            return user;
        }

        // PUT: api/User/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754

        [Authorize(Roles = "Admin")]
        [HttpPut("{id}")]
        public async Task<ActionResult<User>> PutUser(int id, [FromForm] UserRequest userRequest)
        {
            if (id != userRequest.Id)
            {
                return BadRequest();
            }

            try
            {
                return await _userRepository.UpdateUser(userRequest, Request.Headers["origin"]);
            }
            catch (Exception e)
            {
                return BadRequest(new { errors = e.Message });
            }
        }


        // POST: api/User
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [Authorize(Roles = "Admin")]
        [HttpPost]
        public async Task<ActionResult<User>> PostUser(User user)
        {
            var createdUser = await _userRepository.CreateUser(user);
            if (createdUser == null)
            {
                return BadRequest();
            }
            return CreatedAtAction("GetUser", new { id = user.Id }, user);

        }

        // DELETE: api/User/5
        [Authorize(Roles = "Admin")]
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUser(int id)
        {
            try
            {
                var user = await _userRepository.DeleteUser(id);
                return NoContent();
            }

            catch (Exception e)
            {
                return BadRequest(new { errors = e.Message });
            }
        }

        [Authorize(Roles = "Admin,User")]
        [HttpPost("sendVerificationEmail")]
        public async Task<ActionResult<User>> sendVerificationEmail()
        {
            var userId = _tokenService.getUserId();

            try
            {
                await _userRepository.sendVerificationEmail(userId, Request.Headers["origin"]);
                return Ok(new { message = "Verification email sent" });
            }
            catch (Exception e)
            {
                return BadRequest(new { errors = e.Message });
            }
        }

        [HttpPost("verifyEmail")]
        public async Task<ActionResult> verifyEmail(VerificationRequest request)
        {
            try
            {
                var user = await _userRepository.verifyEmail(request.Token);
                return Ok(new { message = "Email verified" });
            }
            catch (Exception e)
            {
                return BadRequest(new { errors = e.Message });
            }
        }

        [HttpPost("forgotPassword")]
        public async Task<ActionResult> forgotPassword(ForgotPasswordRequest request)
        {
            try
            {
                await _userRepository.forgotPassword(request.Email, Request.Headers["origin"]);

                return Ok(new { message = "Password reset email sent" });
            }
            catch (Exception e)
            {
                return BadRequest(new { errors = e.Message });
            }
        }

        [HttpPost("resetPassword")]
        public async Task<ActionResult> resetPassword(ResetPasswordRequest request)
        {
            try
            {
                await _userRepository.resetPassword(request.Token, request.Password, request.ConfirmPassword);
                return Ok(new { message = "Password reset" });
            }
            catch (Exception e)
            {
                return BadRequest(new { errors = e.Message });
            }
        }

        [Authorize(Roles = "Admin,User")]
        [HttpGet("search")]
        public async Task<ActionResult<IEnumerable<User>>> search([FromQuery] string query)
        {
            var users = await _userRepository.search(query);
            return Ok(users);
        }


    }
}
