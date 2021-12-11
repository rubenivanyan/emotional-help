using PsychologicalAssistance.Core.Data.DTOs;
using PsychologicalAssistance.Core.Data.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PsychologicalAssistance.Core.Repositories.Interfaces
{
    public interface IComputerGameRepository : IDataRepository<ComputerGame>
    {
        Task<IEnumerable<ComputerGameDto>> GetAllComputerGamesDtoAsync();
        Task<ComputerGameDto> GetComputerGameByIdDtoAsync(int id);
    }
}
