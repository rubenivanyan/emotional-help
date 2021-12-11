using PsychologicalAssistance.Core.Data.DTOs;
using PsychologicalAssistance.Core.Data.Entities;
using PsychologicalAssistance.Core.Repositories.Interfaces;
using PsychologicalAssistance.Services.Abstract;
using PsychologicalAssistance.Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PsychologicalAssistance.Services.Implementation
{
    public class MusicService : BaseService<Music>, IMusicService
    {
        private readonly IMusicRepository _musicRepository;

        public MusicService(IDataRepository<Music> dataRepository, IUnitOfWork unitOfWork, IMusicRepository musicRepository)
            : base(dataRepository, unitOfWork)
        {
            _musicRepository = musicRepository;
        }

        public async Task<IEnumerable<MusicDto>> GetAllMusicsAsync()
            => await _musicRepository.GetAllMusicsDtoAsync();

        public async Task<MusicDto> GetMusicByIdAsync(int id)
            => await _musicRepository.GetMusicByIdDtoAsync(id);
    }
}
