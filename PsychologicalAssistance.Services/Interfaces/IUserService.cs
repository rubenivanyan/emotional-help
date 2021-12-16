using Microsoft.AspNetCore.Identity;
using PsychologicalAssistance.Core.Data.DTOs;
using PsychologicalAssistance.Core.Data.Entities;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;

namespace PsychologicalAssistance.Services.Interfaces
{
    public interface IUserService
    {
        Task<IEnumerable<IdentityError>> RegisterUserAsync(User user, string password);
        Task<ClaimsIdentity> LoginUserAsync(string email, string password);
        Task<IEnumerable<UserDto>> GetAllUsersDtoAsync();
    }
}
