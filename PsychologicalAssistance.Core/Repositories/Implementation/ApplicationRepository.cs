using PsychologicalAssistance.Core.Data;
using PsychologicalAssistance.Core.Data.DTOs;
using PsychologicalAssistance.Core.Data.Enitities;
using PsychologicalAssistance.Core.Repositories.Abstract;
using PsychologicalAssistance.Core.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PsychologicalAssistance.Core.Repositories.Implementation
{
    public class ApplicationRepository : DataRepository<Application>, IApplicationRepository
    {
        public ApplicationRepository(ApplicationDbContext dbContext) : base (dbContext) { }

        public Task<IEnumerable<ApplicationDto>> GetAllApplicationsDtoAsync()
        {
            return null;
        }

        public async Task<ApplicationDto> GetApplicationByIdDtoAsync(int id)
        {
            //TODO After adding application into db finish this method
            //var application = await Task.Run(() => DbSet.Select(application => new ApplicationDto()) as ApplicationDto);

            //For testing
            var applicationDto = new ApplicationDto
            {
                Id = 1,
                FullName = "Name Surname",
                MailAddress = "some@address.com",
                Date = new DateTime(2021, 12, 10),
                TestTitle = "Test Title",
                QuestionsAndAnswers = new Dictionary<string, string> 
                {
                    {"Question 1", "Answer 1" },
                    {"Question 2", "Answer 2" }
                },
                IsArchived = true
            };
            return applicationDto;
        }
    }
}
