using PsychologicalAssistance.Core.Data.DTOs;
using PsychologicalAssistance.Core.Data.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PsychologicalAssistance.Core.Repositories.Interfaces
{
    public interface IMusicRepository : IDataRepository<Music>
    {
        Task<IEnumerable<MusicDto>> GetAllMusicsDtoAsync();
        Task<MusicDto> GetMusicByIdDtoAsync(int id);
        Task<IEnumerable<MusicDto>> GetMusicByGenreDtoAsync(List<string> genres);
    }
}
