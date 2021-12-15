using System.Linq;

namespace PsychologicalAssistance.Core.Data.Seeding.DbInitializers
{
    public class BooksInitializer : IDbInitializers
    {
        public void Initialize(ApplicationDbContext dbContext)
        {
            if (dbContext.Books.Any())
            {
                return;
            }

            dbContext.Books.AddRange(DefaultObjects.BooksObjects);
            dbContext.SaveChanges();
        }
    }
}
