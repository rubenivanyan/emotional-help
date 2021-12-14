using AutoMapper;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PsychologicalAssistance.Core.Data.DTOs;
using PsychologicalAssistance.Core.Data.Entities;
using PsychologicalAssistance.Services.Interfaces;
using System.Threading.Tasks;
using System.Security.Claims;

namespace PsychologicalAssistance.Web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IMapper _mapper;

        public UserController(IMapper mapper, IUserService userService)
        {
            _userService = userService;
            _mapper = mapper;
        }

        [HttpPost("login")]
        public async Task<ActionResult> Login([FromBody] UserLoginDto userLoginDto)
        {
            var identity = await _userService.LoginUserAsync(userLoginDto.Email, userLoginDto.Password);
            if (identity != null)
            {
                await HttpContext.SignInAsync(IdentityConstants.ApplicationScheme, new ClaimsPrincipal(identity));
                return Ok();
            }

            return BadRequest("Invalid UserName or Password");
        }

        [HttpPost("register")]
        public async Task<ActionResult> Register([FromBody] UserRegistrationDto userRegistrationDto)
        {
            var user = _mapper.Map<UserRegistrationDto, User>(userRegistrationDto);
            var result = await _userService.RegisterUserAsync(user, userRegistrationDto.Password);
            return result is null ? Ok() : BadRequest(result);
        }

        [HttpPost("logout")]
        public async Task Logout()
        {
            var cookies = HttpContext.Request.Cookies.Keys;
            foreach(var cookie in cookies)
            {
                HttpContext.Response.Cookies.Delete(cookie);
            }
            await HttpContext.SignOutAsync();
        }
    }
}
