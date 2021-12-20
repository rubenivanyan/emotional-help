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
    public class GenreRepository : DataRepository<Genre>, IGenreRepository
    {
        private readonly IMapper _mapper;

        public GenreRepository(ApplicationDbContext dbContext, IMapper mapper) : base(dbContext)
        {
            _mapper = mapper;
        }

        public async Task<IEnumerable<GenreDto>> GetAllGenresDtoAsync()
        {
            var genres = await GetAllItemsAsync();
            if (genres == null)
            {
                return null;
            }

            var genresDto = _mapper.Map<IEnumerable<Genre>, IEnumerable<GenreDto>>(genres);
            return genresDto;
        }

        public async Task<GenreDto> GetGenreByIdDtoAsync(int id)
        {
            var genre = await GetItemByIdAsync(id);
            if (genre == null)
            {
                return null;
            }

            var genreDto = _mapper.Map<Genre, GenreDto>(genre);
            return genreDto;
        }
    }
}
