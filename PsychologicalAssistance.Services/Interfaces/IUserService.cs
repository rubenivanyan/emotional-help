using PsychologicalAssistance.Core.Data.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PsychologicalAssistance.Services.Interfaces
{
    public interface IUserService
    {
        //TODO Add unique methods' signatures for service
        Task<UserDto> GetUserByIdAsync(int id);
        Task<IEnumerable<UserDto>> GetAllUsersAsync();
        Task CreateAsync(UserDto item);
        Task DeleteAsync(int id);
        Task UpdateAsync(UserDto item);
    }
}
