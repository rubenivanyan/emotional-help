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
        Task<int> CreateTestResultsAsync(TestResultsDto testResultsDto, User user);
        Task<TestResultsForUserDto> GetTestResultsForUserByIdAsync(int id);
        Task<TestResultsForGuestWithRecommendationsDto> CreateTestResultsForGuestAsync(TestResultsDto testResultsDto);
    }
}
