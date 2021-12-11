using PsychologicalAssistance.Core.Data.DTOs;
using PsychologicalAssistance.Core.Data.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PsychologicalAssistance.Core.Repositories.Interfaces
{
    public interface IFilmRepository : IDataRepository<Film>
    {
        public Task<IEnumerable<FilmDto>> GetAllFilmsDtoAsync();
        public Task<FilmDto> GetFilmByIdDtoAsync(int id);
    }
}
