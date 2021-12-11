using PsychologicalAssistance.Core.Data.DTOs;
using PsychologicalAssistance.Core.Data.Entities;
using PsychologicalAssistance.Core.Repositories.Interfaces;
using PsychologicalAssistance.Services.Abstract;
using PsychologicalAssistance.Services.Interfaces;
using System.Threading.Tasks;

namespace PsychologicalAssistance.Services.Implementation
{
    public class TestResultsService : BaseService<TestResults>, ITestResultsService
    {
        private readonly ITestResultsRepository _testResultsRepository;

        public TestResultsService(IDataRepository<TestResults> dataRepository, IUnitOfWork unitOfWork, ITestResultsRepository testResultsRepository)
            : base(dataRepository, unitOfWork)
        {
            _testResultsRepository = testResultsRepository;
        }
        public async Task<TestResultsDto> GetTestResultsByIdAsync(int id)
            => await _testResultsRepository.GetTestResultsByIdDtoAsync(id);
    }
}
