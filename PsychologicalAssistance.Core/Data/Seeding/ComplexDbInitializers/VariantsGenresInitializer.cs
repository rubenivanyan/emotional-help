using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace PsychologicalAssistance.Core.Data.Seeding.ComplexDbInitializers
{
    public class VariantsGenresInitializer : IDbInitializers
    {
        public void Initialize(ApplicationDbContext dbContext)
        {
            var variants = dbContext.Variants.Include(g => g.Genres).ToList();
            if (variants.Any(variant => variant.Genres.Count != 0))
            {
                return;
            }

            var genres = dbContext.Genres.ToList();
            var index = 0;
            foreach(var variant in variants)
            {
                for(int i = 0; i < 5; i++)
                {
                    if (index + 1 == genres.Count)
                    {
                        index = 0;
                    }

                    variant.Genres.Add(genres[index++]);
                }
            }

            dbContext.SaveChanges();
        }
    }
}
