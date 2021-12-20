using AutoMapper;
using PsychologicalAssistance.Core.Data;
using PsychologicalAssistance.Core.Data.Entities;
using PsychologicalAssistance.Core.Data.Helpers.AutoMapper;
using PsychologicalAssistance.Core.Enums;
using PsychologicalAssistance.Core.Repositories.Implementation;
using PsychologicalAssistance.Tests.Common;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace PsychologicalAssistance.Tests.RepositoriesTests
{
    public class QuestionRepositoryTests : InMemoryDatabaseCreation
    {
        private readonly IMapper _mapper;
        public QuestionRepositoryTests()
        {
            Setup();
            _mapper = BasicClassForMocking.ConfigMapper(new QuestionProfile());
        }

        [Fact]
        public async Task QuestionRepository_GetAllQuestions_ReturnAllValues()
        {
            using (var context = new ApplicationDbContext(dbContextOptions))
            {
                //arrange
                var questionRepository = new QuestionRepository(context, _mapper);

                //act
                var questions = await questionRepository.GetAllQuestionsDtoAsync();

                //assert
                Assert.NotNull(questions.ToList());
                Assert.Equal(5, questions.ToList().Count);
                Assert.Equal(5, questions.Select(b => b.Id).First());
                 
            }
        }

        [Fact]

        public async Task QuestionRepository_GetQuestionById_ReturnValueById()
        {
            using (var context = new ApplicationDbContext(dbContextOptions))
            {
                //arrange
                int id = 1;
                var questionRepository = new QuestionRepository(context, _mapper);

                //act
                var question = await questionRepository.GetQuestionByIdDtoAsync(id);

                //assert
                Assert.NotNull(question);
                Assert.Equal("Asthenia", question.QuestionGroup);
                Assert.Equal("---", question.ImageUrl);
                Assert.Equal("What was your emotion in the morning?", question.Formulation);
            }
        }

        [Fact]
        public async Task QuestionRepository_GetQuestionById()
        {
            using (var context = new ApplicationDbContext(dbContextOptions))
            {
                //arrange
                int id = 1;
                var questionRepository = new QuestionRepository(context, _mapper);

                //act
                var question = await questionRepository.GetQuestionByIdDtoAsync(id);

                //assert
                var expected = ExpectedQuestions.FirstOrDefault(x => x.Id == id);
                Assert.Equal(expected.Id, question.Id);
                Assert.NotNull(question);

            }
        }

        private static IEnumerable<Question> ExpectedQuestions =>
           new[]
           {
                new Question { Id = 1, Formulation = "What was your emotion in the morning?", QuestionGroup = QuestionGroups.Asthenia, ImageUrl = "---"},
                new Question { Id = 2, Formulation = "What is your emotion now?",             QuestionGroup = QuestionGroups.SocialAnxiety, ImageUrl = "---"},
           };
    }
}
