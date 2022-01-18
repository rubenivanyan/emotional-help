using PsychologicalAssistance.Core.Data.DTOs;
using PsychologicalAssistance.Core.Data.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PsychologicalAssistance.Core.Repositories.Interfaces
{
    public interface ITestResultsRepository : IDataRepository<TestResults>
    {
        Task<IEnumerable<TestResultsDto>> GetAllTestsResultsDtoAsync();
        Task<TestResultsDto> GetTestResultsByIdDtoAsync(int id);
        Task<TestResultsForUserDto> GetTestResultsForUserByIdAsync(int id);
        Task<List<AnswerDto>> GetAnswersByUserIdAsync(int testResultsId, string userId);
    }
}
