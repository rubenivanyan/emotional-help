using PsychologicalAssistance.Core.Data.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PsychologicalAssistance.Core.Repositories.Interfaces
{
    public interface IEmotionGenreRepository : IDataRepository<EmotionGenre>
    {
        Task<List<string>> GetGenreByEmotionAsync(string emotion);
    }
}
