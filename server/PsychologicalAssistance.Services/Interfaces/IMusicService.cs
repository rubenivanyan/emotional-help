using PsychologicalAssistance.Core.Data.DTOs;
using PsychologicalAssistance.Core.Data.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PsychologicalAssistance.Services.Interfaces
{
    public interface IMusicService : IBaseService<Music>
    {
        Task<IEnumerable<MusicDto>> GetAllMusicsAsync();
        Task<MusicDto> GetMusicByIdAsync(int id);
    }
}
