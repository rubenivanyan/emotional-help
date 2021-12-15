using PsychologicalAssistance.Core.Data.DTOs;
using PsychologicalAssistance.Core.Data.Entities;
using PsychologicalAssistance.Core.Repositories.Interfaces;
using PsychologicalAssistance.Services.Abstract;
using PsychologicalAssistance.Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PsychologicalAssistance.Services.Implementation
{
    public class GenreService : BaseService<Genre>, IGenreService
    {
        private readonly IGenreRepository _genreRepository;

        public GenreService(IDataRepository<Genre> dataRepository, IUnitOfWork unitOfWork, IGenreRepository genreRepository)
            : base (dataRepository, unitOfWork)
        {
            _genreRepository = genreRepository;
        }

        public async Task<IEnumerable<GenreDto>> GetAllGenresAsync()
            => await _genreRepository.GetAllGenresDtoAsync();

        public async Task<GenreDto> GetGenreByIdAsync(int id)
            => await _genreRepository.GetGenreByIdDtoAsync(id);
    }
}
