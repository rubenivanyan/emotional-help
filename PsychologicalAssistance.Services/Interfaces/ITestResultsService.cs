using PsychologicalAssistance.Core.Data.DTOs;
using PsychologicalAssistance.Core.Data.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PsychologicalAssistance.Services.Interfaces
{
    public interface ITestResultsService : IBaseService<TestResults>
    {
        Task<IEnumerable<TestResultsDto>> GetAllTestsResultsAsync();
        Task<TestResultsDto> GetTestResultsByIdAsync(int id);
    }
}
