using AutoMapper;
using Microsoft.EntityFrameworkCore;
using PsychologicalAssistance.Core.Data;
using PsychologicalAssistance.Core.Data.DTOs;
using PsychologicalAssistance.Core.Data.Entities;
using PsychologicalAssistance.Core.Repositories.Abstract;
using PsychologicalAssistance.Core.Repositories.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PsychologicalAssistance.Core.Repositories.Implementation
{
    public class TestingApplicationRepository : DataRepository<TestingApplication>, ITestingApplicationRepository
    {
        private readonly IMapper _mapper;

        public TestingApplicationRepository(ApplicationDbContext dbContext, IMapper mapper) : base (dbContext)
        {
            _mapper = mapper;
        }

        public async Task<IEnumerable<TestingApplicationDto>> GetAllTestingApplicationsDtoAsync()
        {
            var testingApplications = await GetAllItemsAsync();
            if (testingApplications == null)
            {
                return null;
            }

            var testingApplicationsDto = _mapper.Map<IEnumerable<TestingApplication>, IEnumerable<TestingApplicationDto>>(testingApplications);
            return testingApplicationsDto;
        }

        public async Task<FullTestingApplicationDto> GetFullTestingApplicationDtoByIdAsync(int id)
        {
            var fullTestingApplicationDtoWithUserInfo = await Task.Run(() => DbSet.Include(testingApplication => testingApplication.TestResults)
                .ThenInclude(testingResults => testingResults.User)
                .Where(testingApplication => testingApplication.Id == id)
                .Select(testingApplication => new FullTestingApplicationDto
                {
                    Id = testingApplication.Id,
                    IsArchived = testingApplication.IsArchived,
                    TestResultsId = testingApplication.TestResultsId,
                    DateOfResults = testingApplication.TestResults.ResultsDate.ToShortDateString(),
                    UserName = testingApplication.TestResults.User.UserName,
                    Email = testingApplication.TestResults.User.Email
                }).FirstOrDefault());

            var fullTestingApplicationDtoWithAnswerInfo = await Task.Run(() => DbSet.Include(testingApplication => testingApplication.TestResults)
                .ThenInclude(testingResults => testingResults.Answers)
                .ThenInclude(answers => answers.Question)
                .Where(testingApplication => testingApplication.Id == id)
                .Select(testingApplication => new FullTestingApplicationDto
                {
                    AnswersFormulations = testingApplication.TestResults.Answers.Select(answer => answer.Formulation).ToList(),
                    QuestionsFormulations = testingApplication.TestResults.Answers.Select(answer => answer.Question.Formulation).ToList()
                }).FirstOrDefault());

            fullTestingApplicationDtoWithUserInfo.AnswersFormulations = fullTestingApplicationDtoWithAnswerInfo.AnswersFormulations;
            fullTestingApplicationDtoWithUserInfo.QuestionsFormulations = fullTestingApplicationDtoWithAnswerInfo.QuestionsFormulations;
            return fullTestingApplicationDtoWithUserInfo;
        }

        public async Task<IEnumerable<FullTestingApplicationDto>> GetFullTestingApplicationDtoByUserIdAsync(string UserId)
        {
            var fullTestingApplicationDtoWithUserIdInfo = await Task.Run(() => DbSet.Include(testingApplication => testingApplication.TestResults)
                .ThenInclude(testingResults => testingResults.User)
                .Where(testingApplication => testingApplication.TestResults.UserId == UserId)
                .Select(testingApplication => new FullTestingApplicationDto
                {
                    Id = testingApplication.Id,
                    IsArchived = testingApplication.IsArchived,
                    TestResultsId = testingApplication.TestResultsId,
                    DateOfResults = testingApplication.TestResults.ResultsDate.ToShortDateString(),
                    UserName = testingApplication.TestResults.User.UserName,
                    Email = testingApplication.TestResults.User.Email
                }).ToList());

            var fullTestingApplicationDtoWithAnswerInfo = await Task.Run(() => DbSet.Include(testingApplication => testingApplication.TestResults)
                .ThenInclude(testingResults => testingResults.Answers)
                .ThenInclude(answers => answers.Question)
                .Where(testingApplication => testingApplication.TestResults.UserId == UserId)
                .Select(testingApplication => new FullTestingApplicationDto
                {
                    AnswersFormulations = testingApplication.TestResults.Answers.Select(answer => answer.Formulation).ToList(),
                    QuestionsFormulations = testingApplication.TestResults.Answers.Select(answer => answer.Question.Formulation).ToList()
                }).ToList());

            for (int i = 0; i < fullTestingApplicationDtoWithAnswerInfo.Count; i++)
            {
                fullTestingApplicationDtoWithUserIdInfo[i].AnswersFormulations = fullTestingApplicationDtoWithAnswerInfo[i].AnswersFormulations;
                fullTestingApplicationDtoWithUserIdInfo[i].QuestionsFormulations = fullTestingApplicationDtoWithAnswerInfo[i].QuestionsFormulations;
            }

            return fullTestingApplicationDtoWithUserIdInfo;
        }


        public async Task<TestingApplicationDto> GetTestingApplicationByIdDtoAsync(int id)
        {
            var testingApplication = await GetItemByIdAsync(id);
            if (testingApplication == null)
            {
                return null;
            }

            var testingApplicationDto = _mapper.Map<TestingApplication, TestingApplicationDto>(testingApplication);
            return testingApplicationDto;
        }
    }
}
