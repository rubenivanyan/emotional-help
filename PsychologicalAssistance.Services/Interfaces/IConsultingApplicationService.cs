using PsychologicalAssistance.Core.Data.DTOs;
using PsychologicalAssistance.Core.Data.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PsychologicalAssistance.Services.Interfaces
{
    public interface IConsultingApplicationService : IBaseService<ConsultingApplication>
    {
        Task<IEnumerable<ConsultingApplicationDto>> GetAllConsultingApplicationsAsync();
        Task<ConsultingApplicationDto> GetConsultingApplicationByIdAsync(int id);
        Task<IEnumerable<FullConsultingApplicationDto>> GetAllConsultingApplicationsWithUserInfoAsync();
        Task<FullConsultingApplicationDto> GetConsultingApplicationWithUserInfoByIdAsync(int id);
        Task<IEnumerable<FullConsultingApplicationDto>> GetConsultingApplicationWithUserInfoByUserIdAsync(string userId);
    }
}
