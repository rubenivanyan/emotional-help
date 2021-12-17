using AutoMapper;
using Microsoft.AspNetCore.Identity;
using PsychologicalAssistance.Core.Data.DTOs;
using PsychologicalAssistance.Core.Data.Entities;
using PsychologicalAssistance.Services.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace PsychologicalAssistance.Services.Implementation
{
    public class UserService : IUserService
    {
        private readonly UserManager<User> _userManager;
        private readonly IMapper _mapper;
        
        public UserService(UserManager<User> userManager, IMapper mapper)
        {
            _userManager = userManager;
            _mapper = mapper;
        }

        public async Task<IEnumerable<UserDto>> GetAllUsersDtoAsync()
        {
            var users = await Task.Run(() => _userManager.Users.Select(user => new UserDto
            {
                Id = user.Id,
                FullName = user.UserName + " " + user.UserSurname,
                BirthDate = user.BirthDate.ToShortDateString(),
                Email = user.Email
            }).ToList());

            return users;
        }

        public async Task<UserDto> GetUsersInformationForAccount(string userId)
        {
            var user = await _userManager.FindByIdAsync(userId);
            var userDto = _mapper.Map<User, UserDto>(user);
            return userDto;
        }

        public async Task<ClaimsIdentity> LoginUserAsync(string email, string password)
        {
            var user = await _userManager.FindByEmailAsync(email);
            if (user != null && await _userManager.CheckPasswordAsync(user, password))
            {
                var roles = await _userManager.GetRolesAsync(user);
                var identity = new ClaimsIdentity(IdentityConstants.ApplicationScheme);
                identity.AddClaim(new Claim(ClaimTypes.NameIdentifier, user.Id));
                identity.AddClaim(new Claim(ClaimTypes.Name, user.UserName));
                foreach (var role in roles)
                {
                    identity.AddClaim(new Claim(ClaimTypes.Role, role));
                }

                return identity;
            }

            return null;
        }

        public async Task<IEnumerable<IdentityError>> RegisterUserAsync(User user, string password)
        {
            var result = await _userManager.CreateAsync(user, password);
            if(!result.Succeeded)
            {
                return result.Errors;
            }

            await _userManager.AddToRoleAsync(user, "Client");
            return null;
        }
    }
}
