using PsychologicalAssistance.Core.Data.DTOs;
using PsychologicalAssistance.Core.Data.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PsychologicalAssistance.Services.Interfaces
{
    public interface IFilmService : IBaseService<Film>
    {
        Task<FilmDto> GetFilmByIdAsync(int id);
        Task<IEnumerable<FilmDto>> GetAllFilmsAsync();
    }
}
