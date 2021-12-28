using Microsoft.EntityFrameworkCore;
using PsychologicalAssistance.Core.Data.Entities;
using System.Linq;

namespace PsychologicalAssistance.Core.Data.Seeding.ComplexDbInitializers
{
    public class QuestionVariantsInitializer : IDbInitializers
    {
        public void Initialize(ApplicationDbContext dbContext)
        {
            var questions = dbContext.Questions.Include(v => v.Variants).ToList();
            if (questions.Any(question => question.Variants.Count != 0))
            {
                return;
            }

            var variants = dbContext.Variants.ToList();
            var index = 0;
            foreach(var question in questions)
            {
                for (int i = 0; i < 5; i++)
                {
                    if (index + 1 == variants.Count)
                    {
                        index = 0;
                    }

                    question.Variants.Add(variants[index++]);
                }
            }

            dbContext.SaveChanges();
        }
    }
}
