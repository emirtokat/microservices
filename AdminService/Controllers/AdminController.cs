using AdminService.Models;
using AdminService.Services;
using Microsoft.AspNetCore.Mvc;

namespace AdminService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminsController : ControllerBase
    {
        private readonly UserManagementService _userManagementService;

        public AdminsController(UserManagementService userManagementService)
        {
            _userManagementService = userManagementService;
        }

        [HttpPost("users")]
        public async Task<IActionResult> AddUser([FromBody] User user)
        {
            var response = await _userManagementService.AddUser(user);
            if (response.IsSuccessStatusCode)
            {
                return Ok();
            }
            return StatusCode((int)response.StatusCode, response.ReasonPhrase);
        }

        [HttpPut("users/{id}")]
        public async Task<IActionResult> UpdateUser(int id, [FromBody] User user)
        {
            var response = await _userManagementService.UpdateUser(id, user);
            if (response.IsSuccessStatusCode)
            {
                return Ok();
            }
            return StatusCode((int)response.StatusCode, response.ReasonPhrase);
        }

        [HttpDelete("users/{id}")]
        public async Task<IActionResult> DeleteUser(int id)
        {
            var response = await _userManagementService.DeleteUser(id);
            if (response.IsSuccessStatusCode)
            {
                return Ok();
            }
            return StatusCode((int)response.StatusCode, response.ReasonPhrase);
        }
    }
}
