using PsychologicalAssistance.Core.Data.DTOs;
using PsychologicalAssistance.Core.Data.Entities;
using PsychologicalAssistance.Core.Repositories.Interfaces;
using PsychologicalAssistance.Services.Abstract;
using PsychologicalAssistance.Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

namespace PsychologicalAssistance.Services.Implementation
{
    public class ApplicationService : BaseService<Application>, IApplicationService
    {
        private readonly IApplicationRepository _applicationRepository;

        public ApplicationService(IDataRepository<Application> dataRepository, IUnitOfWork unitOfWork, IApplicationRepository applicationRepository)
            : base (dataRepository, unitOfWork)
        {
            _applicationRepository = applicationRepository;
        }

        public async Task<IEnumerable<ApplicationDto>> GetAllApplicationsAsync()
            => await _applicationRepository.GetAllApplicationsDtoAsync();

        public async Task<ApplicationDto> GetApplicationByIdAsync(int id)
            => await _applicationRepository.GetApplicationByIdDtoAsync(id);

        public async Task<FullApplicationDto> GetFullApplicationDtoByIdAsync(int id)
        {
            var application = await _applicationRepository.GetItemByIdAsync(id);

            var fullApplication = new FullApplicationDto()
            {
                Id = application.Id,
                UserName = application.TestResults.User.UserName,
                Email = application.TestResults.User.Email,
                Message = application.Message,
                QuestionsFormulations = application.TestResults.Answers.Select(i => i.Question.Formulation).ToList(),
                AnswersFormulations = application.TestResults.Answers.Select(i => i.Formulation).ToList(),
                DateOfResults = application.TestResults.ResultsDate.ToShortDateString()
            };

            return fullApplication;
        }
    }
}
