using System.Linq;

namespace PsychologicalAssistance.Core.Data.Seeding.DbInitializers
{
    public class TrainingsInitializer : IDbInitializers
    {
        public void Initialize(ApplicationDbContext dbContext)
        {
            if (dbContext.Trainings.Any())
            {
                return;
            }

            dbContext.Trainings.AddRange(DefaultObjects.TrainingsObjects);
            dbContext.SaveChanges();
        }
    }
}
