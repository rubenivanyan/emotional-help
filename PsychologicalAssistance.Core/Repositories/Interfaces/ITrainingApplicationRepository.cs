using PsychologicalAssistance.Core.Data.DTOs;
using PsychologicalAssistance.Core.Data.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PsychologicalAssistance.Core.Repositories.Interfaces
{
    public interface ITrainingApplicationRepository : IDataRepository<TrainingApplication>
    {
        Task<IEnumerable<FullTrainingApplicationDto>> GetAllTrainingApplicationsDtoAsync();
        Task<FullTrainingApplicationDto> GetTrainingApplicationDtoByIdAsync(int id);
    }
}
