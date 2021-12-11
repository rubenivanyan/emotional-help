using PsychologicalAssistance.Core.Data.DTOs;
using PsychologicalAssistance.Core.Data.Entities;
using System.Threading.Tasks;

namespace PsychologicalAssistance.Core.Repositories.Interfaces
{
    public interface ITestResultsRepository : IDataRepository<TestResults>
    {
        Task<TestResultsDto> GetTestResultsByIdDtoAsync(int id);
    }
}
