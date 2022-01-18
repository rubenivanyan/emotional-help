using System.Linq;

namespace PsychologicalAssistance.Core.Data.Seeding.DbInitializers
{
    public class VariantsInitializer : IDbInitializers
    {
        public void Initialize(ApplicationDbContext dbContext)
        {
            if (dbContext.Variants.Any())
            {
                return;
            }

            dbContext.Variants.AddRange(DefaultObjects.VariantsObjects);
            dbContext.SaveChanges();
        }
    }
}
