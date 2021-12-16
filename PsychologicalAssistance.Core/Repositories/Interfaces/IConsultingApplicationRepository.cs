using PsychologicalAssistance.Core.Data.DTOs;
using PsychologicalAssistance.Core.Data.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PsychologicalAssistance.Core.Repositories.Interfaces
{
    public interface IConsultingApplicationRepository : IDataRepository<ConsultingApplication>
    {
        Task<IEnumerable<ConsultingApplicationDto>> GetAllConsultingApplicationsDtoAsync();
        Task<ConsultingApplicationDto> GetConsultingApplicationByIdDtoAsync(int id);
    }
}
