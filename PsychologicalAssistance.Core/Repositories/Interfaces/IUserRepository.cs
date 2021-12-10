using PsychologicalAssistance.Core.Data.DTOs;
using PsychologicalAssistance.Core.Data.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PsychologicalAssistance.Core.Repositories.Interfaces
{
    public interface IUserRepository : IDataRepository<User>
    {
        Task<IEnumerable<UserDto>> GetAllUsersDtoAsync();
        Task<UserDto> GetUserByIdDtoAsync(int id);
    }
}
