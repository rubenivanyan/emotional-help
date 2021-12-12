using Microsoft.AspNetCore.Identity;
using PsychologicalAssistance.Core.Data.DTOs;
using PsychologicalAssistance.Core.Data.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PsychologicalAssistance.Services.Interfaces
{
    public interface IUserService
    {
        Task<IEnumerable<IdentityError>> RegisterUser(User user, string password); 
    }
}
