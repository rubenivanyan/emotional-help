using AutoMapper;
using PsychologicalAssistance.Core.Data;
using PsychologicalAssistance.Core.Data.DTOs;
using PsychologicalAssistance.Core.Data.Entities;
using PsychologicalAssistance.Core.Repositories.Abstract;
using PsychologicalAssistance.Core.Repositories.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PsychologicalAssistance.Core.Repositories.Implementation
{
    public class FilmRepository : DataRepository<Film>, IFilmRepository
    {
        private readonly IMapper _mapper;

        public FilmRepository(ApplicationDbContext dbContext, IMapper mapper) : base(dbContext)
        {
            _mapper = mapper;
        }

        public async Task<IEnumerable<FilmDto>> GetAllFilmsDtoAsync()
        {
            var films = await GetAllItemsAsync();
            if (films == null)
            {
                return null;
            }

            var filmsDto = _mapper.Map<IEnumerable<Film>, IEnumerable<FilmDto>>(films);
            return filmsDto;
        }

        public async Task<FilmDto> GetFilmByIdDtoAsync(int id)
        {

            var films = await GetItemByIdAsync(id);
            if (films == null)
            {
                return null;
            }

            var filmsDto = _mapper.Map<Film, FilmDto>(films);
            return filmsDto;
        }
    }
}
