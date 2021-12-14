using PsychologicalAssistance.Core.Data;
using PsychologicalAssistance.Core.Data.Entities;
using PsychologicalAssistance.Core.Repositories.Abstract;
using PsychologicalAssistance.Core.Repositories.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PsychologicalAssistance.Core.Repositories.Implementation
{
    public class EmotionGenreRepository : DataRepository<EmotionGenre>, IEmotionGenreRepository
    {
        public EmotionGenreRepository(ApplicationDbContext dbContext) : base(dbContext) { }

        public async Task<List<string>> GetGenreByEmotionAsync(string emotion)
        {
            var genres = await Task.Run(() => DbSet
                .Where(emotionsGenres => emotionsGenres.Emotion == emotion)
                .Select(eg => eg.Genre).ToList());
            return genres;
        }
    }
}
