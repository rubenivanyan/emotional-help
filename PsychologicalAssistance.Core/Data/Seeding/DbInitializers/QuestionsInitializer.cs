using System.Linq;

namespace PsychologicalAssistance.Core.Data.Seeding.DbInitializers
{
    public class QuestionsInitializer : IDbInitializers
    {
        public void Initialize(ApplicationDbContext dbContext)
        {
            if (dbContext.Questions.Any())
            {
                return;
            }

            dbContext.Questions.AddRange(DefaultObjects.QuestionsObjects);
            dbContext.SaveChanges();
        }
    }
}
