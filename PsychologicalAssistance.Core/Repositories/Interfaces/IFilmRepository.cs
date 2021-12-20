using PsychologicalAssistance.Core.Data.DTOs;
using PsychologicalAssistance.Core.Data.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PsychologicalAssistance.Core.Repositories.Interfaces
{
    public interface IFilmRepository : IDataRepository<Film>
    {
        Task<IEnumerable<FilmDto>> GetAllFilmsDtoAsync();
        Task<FilmDto> GetFilmByIdDtoAsync(int id);
        Task<IEnumerable<FilmDto>> GetFilmsByGenreDtoAsync(List<string> genres);
    }
}
