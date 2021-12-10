using PsychologicalAssistance.Core.Data.DTOs;
using PsychologicalAssistance.Core.Data.Entities;
using PsychologicalAssistance.Core.Repositories.Interfaces;
using PsychologicalAssistance.Services.Abstract;
using PsychologicalAssistance.Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PsychologicalAssistance.Services.Implementation
{
    public class TestService : BaseService<Test>, ITestService
    {
        private readonly ITestRepository _testRepository;

        public TestService(IDataRepository<Test> dataRepository, ITestRepository testRepository, IUnitOfWork unitOfWork) : base(dataRepository, unitOfWork)
        {
            _testRepository = testRepository;
        }

        public async Task<IEnumerable<TestDto>> GetAllTestsAsync()
            => await _testRepository.GetAllTestsDtoAsync();

        public async Task<TestDto> GetTestByIdAsync(int id)
            => await _testRepository.GetTestByIdDtoAsync(id);
    }
}
