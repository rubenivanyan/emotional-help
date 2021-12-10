using PsychologicalAssistance.Core.Data.DTOs;
using PsychologicalAssistance.Core.Data.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PsychologicalAssistance.Services.Interfaces
{
    public interface IApplicationService : IBaseService<Application>
    {
        Task<IEnumerable<ApplicationDto>> GetAllApplicationsAsync();
        Task<ApplicationDto> GetApplicationByIdAsync(int id);
    }
}
