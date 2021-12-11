using PsychologicalAssistance.Core.Data.DTOs;
using PsychologicalAssistance.Core.Data.Entities;
using PsychologicalAssistance.Core.Repositories.Interfaces;
using PsychologicalAssistance.Services.Abstract;
using PsychologicalAssistance.Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PsychologicalAssistance.Services.Implementation
{
    public class FilmService : BaseService<Film>, IFilmService
    {

        private readonly IFilmRepository _filmRepository;

        public FilmService(IDataRepository<Film> dataRepository, IUnitOfWork unitOfWork, IFilmRepository filmRepository)
            : base(dataRepository, unitOfWork)
        {
            _filmRepository = filmRepository;
        }

        public async Task<IEnumerable<FilmDto>> GetAllFilmsAsync()
            => await _filmRepository.GetAllFilmsDtoAsync();

        public async Task<FilmDto> GetFilmByIdAsync(int id)
            => await _filmRepository.GetFilmByIdDtoAsync(id);












        public Task<IEnumerable<FilmDto>> GetAllTestsAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<FilmDto> GetTestByIdAsync(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
