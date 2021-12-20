using PsychologicalAssistance.Core.Data.DTOs;
using PsychologicalAssistance.Core.Data.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PsychologicalAssistance.Services.Interfaces
{
    public interface ITrainingApplicationService : IBaseService<TrainingApplication>
    {
        Task<FullTrainingApplicationDto> GetTrainingApplicationByIdAsync(int id);
        Task<IEnumerable<FullTrainingApplicationDto>> GetAllTrainingApplicationsAsync();

        Task<IEnumerable<FullTrainingApplicationDto>> GetTrainingApplicationByUserIdAsync(string userId);
    }
}
