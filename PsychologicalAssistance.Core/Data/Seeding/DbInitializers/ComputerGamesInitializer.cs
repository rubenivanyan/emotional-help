using System.Linq;

namespace PsychologicalAssistance.Core.Data.Seeding.DbInitializers
{
    public class ComputerGamesInitializer : IDbInitializers
    {
        public void Initialize(ApplicationDbContext dbContext)
        {
            if (dbContext.ComputerGames.Any())
            {
                return;
            }

            dbContext.AddRange(DefaultObjects.ComputerGamesObjects);
            dbContext.SaveChanges();
        }
    }
}
