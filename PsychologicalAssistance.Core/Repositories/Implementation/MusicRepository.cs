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
    public class MusicRepository : DataRepository<Music>, IMusicRepository
    {
        private readonly IMapper _mapper;

        public MusicRepository(ApplicationDbContext dbContext, IMapper mapper) : base(dbContext)
        {
            _mapper = mapper;
        }

        public async Task<IEnumerable<MusicDto>> GetAllMusicsDtoAsync()
        {
            var musics = await GetAllItemsAsync();
            if (musics == null)
            {
                return null;
            }

            var musicsDto = _mapper.Map<IEnumerable<Music>, IEnumerable<MusicDto>>(musics);
            return musicsDto;
        }

        public async Task<MusicDto> GetMusicByIdDtoAsync(int id)
        {
            var music = await GetItemByIdAsync(id);
            if (music == null)
            {
                return null;
            }

            var musicDto = _mapper.Map<Music, MusicDto>(music);
            return musicDto;
        }
    }
}
