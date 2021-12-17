using PsychologicalAssistance.Core.Data.DTOs;
using PsychologicalAssistance.Core.Data.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PsychologicalAssistance.Services.Interfaces
{
    public interface IApplicationService : IBaseService<TestingApplication>
    {
        Task<IEnumerable<ApplicationDto>> GetAllApplicationsAsync();
        Task<ApplicationDto> GetApplicationByIdAsync(int id);
        Task<FullApplicationDto> GetFullApplicationDtoByIdAsync(int id);
    }
}
