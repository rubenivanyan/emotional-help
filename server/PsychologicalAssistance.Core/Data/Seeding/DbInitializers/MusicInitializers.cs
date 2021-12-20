using System.Linq;

namespace PsychologicalAssistance.Core.Data.Seeding.DbInitializers
{
    public class MusicInitializers : IDbInitializers
    {
        public void Initialize(ApplicationDbContext dbContext)
        {
            if (dbContext.Musics.Any())
            {
                return;
            }

            dbContext.Musics.AddRange(DefaultObjects.MusicObjects);
            dbContext.SaveChanges();
        }
    }
}
