using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using PsychologicalAssistance.Core.Data.Enitities;
using PsychologicalAssistance.Services.Interfaces;
using System.Threading.Tasks;

namespace PsychologicalAssistance.Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("/api/getallusers")]
        public async Task<ActionResult<string>> GetAllUser()
        {
            var users = await _userService.GetAllItemsAsync();
            if (users == null)
            {
                return NotFound();
            }

            var json = JsonSerializer.Serialize(users);
            return json;
        }

        [HttpGet("/api/getuserbyid/{id}")]
        public async Task<ActionResult<string>> GetUserById(int id)
        {
            var user = await _userService.GetItemByIdAsync(id);
            if (user == null)
            {
                return NotFound();
            }

            var json = JsonSerializer.Serialize(user);
            return json;
        }

        [HttpPost("/api/createuser/{json}")]
        public async Task<ActionResult<User>> CreateUser(string json)
        {
            if (json == null)
            {
                return NotFound();
            }

            //TODO Check if object already exists

            var user = JsonSerializer.Deserialize<User>(json);
            await _userService.CreateAsync(user);
            return Ok();
        }

        [HttpPut("/api/updateuser/{json}")]
        public async Task<ActionResult<User>> UpdateUser(string json)
        {
            if (json == null)
            {
                return NotFound();
            }

            var user = JsonSerializer.Deserialize<User>(json);
            await _userService.UpdateAsync(user);
            return Ok();
        }

        [HttpDelete("/api/deleteuser/{json}")]
        public async Task<ActionResult<User>> DeleteUser(string json)
        {
            if (json == null)
            {
                return NotFound();
            }

            var user = JsonSerializer.Deserialize<User>(json);
            await _userService.DeleteAsync(user);
            return Ok();
        }
    }
}
