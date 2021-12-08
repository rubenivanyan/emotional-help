using Microsoft.AspNetCore.Mvc;
using PsychologicalAssistance.Core.Data.Enitities;
using PsychologicalAssistance.Services.Interfaces;
using System.Threading.Tasks;

namespace PsychologicalAssistance.Web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public async Task<ActionResult<string>> GetAllUser()
        {
            var users = await _userService.GetAllItemsAsync();
            if (users == null)
            {
                return NotFound();
            }

            return users is not null ? Ok(users) : NotFound();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<string>> GetUserById(int id)
        {
            var user = await _userService.GetItemByIdAsync(id);
            if (user == null)
            {
                return NotFound();
            }

            return user is not null ? Ok(user) : NotFound();
        }

        [HttpPost]
        public async Task<ActionResult<User>> CreateUser([FromBody] User user)
        {
            if (user is null)
            {
                return NotFound();
            }

            //TODO Check if object already exists

            await _userService.CreateAsync(user);
            return Ok();
        }

        [HttpPut]
        public async Task<ActionResult<User>> UpdateUser([FromBody] User user)
        {
            if (user is null)
            {
                return NotFound();
            }

            await _userService.UpdateAsync(user);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteUser(int id)
        {

            //await _userService.DeleteAsync(id);
            return NoContent();
        }
    }
}
