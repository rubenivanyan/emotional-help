using System.Linq;

namespace PsychologicalAssistance.Core.Data.Seeding.ComplexDbInitializers
{
    public class TestQuestionsInitializers : IComplexDbInitializers
    {
        public void Initialize(ApplicationDbContext dbContext)
        {
            var tests = dbContext.Tests.ToList();
            if (tests.Any(test => test.Questions != null))
            {
                return;
            }

            var questions = dbContext.Questions.ToList();
            foreach(var test in tests)
            {
                for (int i = 0; i < questions.Count; i++)
                {
                    test.Questions.Add(questions[i]);
                }
            }

            dbContext.SaveChanges();
        }
    }
}
