using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PsychologicalAssistance.Core.Data.DTOs;
using PsychologicalAssistance.Core.Data.Entities;
using PsychologicalAssistance.Services.Interfaces;
using System.Threading.Tasks;

namespace PsychologicalAssistance.Web.Controllers
{
    /*[ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IMapper _mapper;

        public UserController(IUserService userService, IMapper mapper)
        {
            _userService = userService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult> GetAllUser()
        {
            var users = await _userService.GetAllUsersAsync();
            return users is not null ? Ok(users) : NotFound();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> GetUserById(int id)
        {
            var user = await _userService.GetUserByIdAsync(id);
            return user is not null ? Ok(user) : NotFound();
        }

        [HttpPost]
        public async Task<ActionResult> CreateUser([FromBody] UserDto userDto)
        {
            //TODO Check if object already exists
            var user = _mapper.Map<User>(userDto);
            await _userService.CreateAsync(user);
            return Ok();
        }

        [HttpPut]
        public async Task<ActionResult> UpdateUser([FromBody] UserDto userDto)
        {
            var user = _mapper.Map<User>(userDto);
            await _userService.UpdateAsync(user);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteUser(int id)
        {
            await _userService.DeleteAsync(id);
            return NoContent();
        }
    }*/
}
