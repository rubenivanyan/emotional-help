using System.Linq;

namespace PsychologicalAssistance.Core.Data.Seeding.ComplexDbInitializers
{
    public class QuestionVariantsInitializers : IComplexDbInitializers
    {
        public void Initialize(ApplicationDbContext dbContext)
        {
            var questions = dbContext.Questions.ToList();
            if (questions.Any(question => question.Variants != null))
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
