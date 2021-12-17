using PsychologicalAssistance.Core.Data.DTOs;
using PsychologicalAssistance.Core.Data.Entities;
using PsychologicalAssistance.Core.Repositories.Interfaces;
using PsychologicalAssistance.Services.Abstract;
using PsychologicalAssistance.Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PsychologicalAssistance.Services.Implementation
{
    public class TestingApplicationService : BaseService<TestingApplication>, ITestingApplicationService
    {
        private readonly ITestingApplicationRepository _testingApplicationRepository;

        public TestingApplicationService(IDataRepository<TestingApplication> dataRepository, IUnitOfWork unitOfWork, ITestingApplicationRepository testingApplicationRepository)
            : base (dataRepository, unitOfWork)
        {
            _testingApplicationRepository = testingApplicationRepository;
        }

        public async Task<IEnumerable<TestingApplicationDto>> GetAllTestingApplicationsAsync()
            => await _testingApplicationRepository.GetAllTestingApplicationsDtoAsync();

        public async Task<TestingApplicationDto> GetTestingApplicationByIdAsync(int id)
            => await _testingApplicationRepository.GetTestingApplicationByIdDtoAsync(id);

        public async Task<FullTestingApplicationDto> GetFullTestingApplicationDtoByIdAsync(int id)
            => await _testingApplicationRepository.GetFullTestingApplicationDtoByIdAsync(id);
    }
}
