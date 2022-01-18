using PsychologicalAssistance.Core.Data.DTOs;
using PsychologicalAssistance.Core.Data.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PsychologicalAssistance.Core.Repositories.Interfaces
{
    public interface IGenreRepository : IDataRepository<Genre>
    {
        Task<GenreDto> GetGenreByIdDtoAsync(int id);
        Task<IEnumerable<GenreDto>> GetAllGenresDtoAsync();
    }
}
