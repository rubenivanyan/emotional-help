using PsychologicalAssistance.Core.Data.DTOs;
using PsychologicalAssistance.Core.Data.Enitities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PsychologicalAssistance.Core.Repositories.Interfaces
{
    public interface IUserRepository : IDataRepository<User>
    {
        //TODO Add unique methods's signatures for repository
        Task<IEnumerable<UserDto>> GetAllUsersDtoAsync();
        Task<UserDto> GetUserByIdDtoAsync(int id);
    }
}
