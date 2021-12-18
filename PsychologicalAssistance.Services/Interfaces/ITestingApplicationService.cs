using PsychologicalAssistance.Core.Data.DTOs;
using PsychologicalAssistance.Core.Data.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PsychologicalAssistance.Services.Interfaces
{
    public interface ITestingApplicationService : IBaseService<TestingApplication>
    {
        Task<IEnumerable<TestingApplicationDto>> GetAllTestingApplicationsAsync();
        Task<TestingApplicationDto> GetTestingApplicationByIdAsync(int id);
        Task<FullTestingApplicationDto> GetFullTestingApplicationDtoByIdAsync(int id);
        Task<FullTestingApplicationDto> GetFullTestingApplicationDtoByUserIdAsync(string id);
    }
}
