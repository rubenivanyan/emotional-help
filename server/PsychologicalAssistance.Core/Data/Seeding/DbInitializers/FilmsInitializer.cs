using System.Linq;

namespace PsychologicalAssistance.Core.Data.Seeding.DbInitializers
{
    public class FilmsInitializer : IDbInitializers
    {
        public void Initialize(ApplicationDbContext dbContext)
        {
            if (dbContext.Films.Any())
            {
                return;
            }

            dbContext.Films.AddRange(DefaultObjects.FilmsObjects);
            dbContext.SaveChanges();
        }
    }
}
