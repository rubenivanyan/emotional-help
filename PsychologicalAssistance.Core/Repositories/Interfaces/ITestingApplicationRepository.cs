using PsychologicalAssistance.Core.Data.DTOs;
using PsychologicalAssistance.Core.Data.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PsychologicalAssistance.Core.Repositories.Interfaces
{
    public interface ITestingApplicationRepository : IDataRepository<TestingApplication>
    {
        Task<IEnumerable<TestingApplicationDto>> GetAllTestingApplicationsDtoAsync();
        Task<TestingApplicationDto> GetTestingApplicationByIdDtoAsync(int id);
        Task<FullTestingApplicationDto> GetFullTestingApplicationDtoByIdAsync(int id);
        Task<IEnumerable<FullTestingApplicationDto>> GetFullTestingApplicationDtoByUserIdAsync(string id);
    }
}
