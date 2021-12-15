using System.Linq;

namespace PsychologicalAssistance.Core.Data.Seeding.ComplexDbInitializers
{
    public class VariantsGenresInitializers : IComplexDbInitializers
    {
        public void Initialize(ApplicationDbContext dbContext)
        {
            var variants = dbContext.Variants.ToList();
            if (variants.Any(variant => variant.Genres != null))
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
