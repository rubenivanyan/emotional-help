using PsychologicalAssistance.Core.Data.DTOs;
using PsychologicalAssistance.Core.Data.Entities;
using PsychologicalAssistance.Core.Enums;
using PsychologicalAssistance.Core.Repositories.Interfaces;
using PsychologicalAssistance.Services.Abstract;
using PsychologicalAssistance.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PsychologicalAssistance.Services.Implementation
{
    public class TestResultsService : BaseService<TestResults>, ITestResultsService
    {
        private readonly ITestResultsRepository _testResultsRepository;
        private readonly ITestRepository _testRepository;

        public TestResultsService(IDataRepository<TestResults> dataRepository, IUnitOfWork unitOfWork, ITestResultsRepository testResultsRepository, ITestRepository testRepository)
            : base(dataRepository, unitOfWork)
        {
            _testResultsRepository = testResultsRepository;
            _testRepository = testRepository;
        }

        public async Task<int> CreateTestResultsAsync(TestResultsDto testResultsDto, User user)
        {
            var testResults = new TestResults
            {
                ResultsDate = DateTime.Now,
                TestId = testResultsDto.TestId,
                UserId = user.Id
            };
            var test = await _testRepository.GetTestWithQuestionsByIdDtoAsync(testResultsDto.TestId);
            if (test == null)
            {
                return -1;
            }

            var answers = new List<Answer>();
            for(int i = 0; i < test.Questions.Count; i++)
            {
                answers.Add(new Answer
                {
                    Formulation = testResultsDto.ChosenVariants[i].Formulation,
                    QuestionId = test.Questions[i].Id
                });
            }

            var questionGroupsValues = new List<QuestionGroupsValues>();
            questionGroupsValues.Add(new QuestionGroupsValues
            {
                QuestionGroup = Enum.Parse<QuestionGroups>(testResultsDto.QuestionsGroups[0]),
                Value = testResultsDto.ChosenVariants[0].Value
            });
            for (int i = 1; i < testResultsDto.ChosenVariants.Count; i++)
            {
                var group = Enum.Parse<QuestionGroups>(testResultsDto.QuestionsGroups[i]);
                var isGroupAdded = false;
                for (int j = 0; j < questionGroupsValues.Count; j++)
                {
                    if (questionGroupsValues[j].QuestionGroup == group)
                    {
                        questionGroupsValues[j].Value += testResultsDto.ChosenVariants[i].Value;
                        isGroupAdded = true;
                    }
                }

                if (!isGroupAdded)
                {
                    questionGroupsValues.Add(new QuestionGroupsValues
                    {
                        QuestionGroup = group,
                        Value = testResultsDto.ChosenVariants[i].Value
                    });
                }
            }

            testResults.QuestionGroupsValues = questionGroupsValues;
            testResults.Answers = answers;
            await _testResultsRepository.CreateAsync(testResults);
            await _unitOfWork.CommitAsync();
            var testResultsId = testResults.Id;
            return testResultsId;
        }

        public async Task<IEnumerable<TestResultsDto>> GetAllTestsResultsAsync()
            => await _testResultsRepository.GetAllTestsResultsDtoAsync();

        public async Task<TestResultsDto> GetTestResultsByIdAsync(int id)
            => await _testResultsRepository.GetTestResultsByIdDtoAsync(id);

        public async Task<TestResultsForUserDto> GetTestResultsForUserByIdAsync(int id)
            => await _testResultsRepository.GetTestResultsForUserByIdAsync(id);
    }
}
