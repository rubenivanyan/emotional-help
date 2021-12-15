using PsychologicalAssistance.Core.Data.DTOs;
using PsychologicalAssistance.Core.Data.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PsychologicalAssistance.Services.Interfaces
{
    public interface IGenreService : IBaseService<Genre>
    {
        Task<GenreDto> GetGenreByIdAsync(int id);
        Task<IEnumerable<GenreDto>> GetAllGenresAsync();
    }
}
