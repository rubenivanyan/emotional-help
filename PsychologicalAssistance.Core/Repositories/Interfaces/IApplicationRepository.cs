using PsychologicalAssistance.Core.Data.DTOs;
using PsychologicalAssistance.Core.Data.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PsychologicalAssistance.Core.Repositories.Interfaces
{
    public interface IApplicationRepository : IDataRepository<Application>
    {
        Task<IEnumerable<ApplicationDto>> GetAllApplicationsDtoAsync();
        Task<ApplicationDto> GetApplicationByIdDtoAsync(int id);
    }
}
