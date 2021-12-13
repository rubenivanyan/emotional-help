using PsychologicalAssistance.Core.Data.DTOs;
using PsychologicalAssistance.Core.Data.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PsychologicalAssistance.Services.Interfaces
{
    public interface ITestService : IBaseService<Test>
    {
        Task<TestDto> GetTestByIdAsync(int id);
        Task<IEnumerable<TestDto>> GetAllTestsAsync();
        Task<IEnumerable<FullTestDto>> GetAllTestsWithQuestion();
        Task<FullTestDto> GetTestWithQuestionsById(int id);
    }
}
