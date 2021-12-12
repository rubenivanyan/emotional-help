using PsychologicalAssistance.Core.Data.DTOs;
using PsychologicalAssistance.Core.Data.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PsychologicalAssistance.Services.Interfaces
{
    public interface IComputerGameService : IBaseService<ComputerGame>
    {
        Task<IEnumerable<ComputerGameDto>> GetAllComputerGamesAsync();
        Task<ComputerGameDto> GetComputerGameByIdAsync(int id);
    }
}
