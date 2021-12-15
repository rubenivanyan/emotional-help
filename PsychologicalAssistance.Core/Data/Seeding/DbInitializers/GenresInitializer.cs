using System.Linq;

namespace PsychologicalAssistance.Core.Data.Seeding.DbInitializers
{
    public class GenresInitializer : IDbInitializers
    {
        public void Initialize(ApplicationDbContext dbContext)
        {
            if (dbContext.Genres.Any())
            {
                return;
            }

            dbContext.Genres.AddRange(DefaultObjects.GenresObjects);
            dbContext.SaveChanges();
        }
    }
}
