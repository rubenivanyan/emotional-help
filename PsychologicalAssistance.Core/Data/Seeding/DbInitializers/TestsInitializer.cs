using System.Linq;

namespace PsychologicalAssistance.Core.Data.Seeding.DbInitializers
{
    public class TestsInitializer : IDbInitializers
    {
        public void Initialize(ApplicationDbContext dbContext)
        {
            if (dbContext.Tests.Any())
            {
                return;
            }

            dbContext.Tests.AddRange(DefaultObjects.TestsObjects);
            dbContext.SaveChanges();
        }
    }
}
