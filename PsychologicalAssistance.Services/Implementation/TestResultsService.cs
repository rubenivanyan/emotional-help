using PsychologicalAssistance.Core.Data.DTOs;
using PsychologicalAssistance.Core.Data.Entities;
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

        public async Task CreateTestResultsAsync(TestResultsDto testResultsDto, User user)
        {
            var testResults = new TestResults
            {
                ResultsDate = DateTime.Now,
                TestId = testResultsDto.TestId,
                UserId = user.Id
            };
            var test = await _testRepository.GetTestWithQuestionsByIdDtoAsync(testResultsDto.TestId);
            var answers = new List<Answer>();
            for(int i = 0; i < test.Questions.Count; i++)
            {
                answers.Add(new Answer
                {
                    Formulation = testResultsDto.ChosenVariants[i].Formulation,
                    QuestionId = test.Questions[i].Id
                });
            }

            testResults.Answers = answers;
            await _testResultsRepository.CreateAsync(testResults);
            await _unitOfWork.CommitAsync();
        }

        public async Task<IEnumerable<TestResultsDto>> GetAllTestsResultsAsync()
            => await _testResultsRepository.GetAllTestsResultsDtoAsync();

        public async Task<TestResultsDto> GetTestResultsByIdAsync(int id)
            => await _testResultsRepository.GetTestResultsByIdDtoAsync(id);

        public async Task<TestResultsForUserDto> GetTestResultsForUserByIdAsync(int id)
            => await _testResultsRepository.GetTestResultsForUserByIdAsync(id);
    }
}
