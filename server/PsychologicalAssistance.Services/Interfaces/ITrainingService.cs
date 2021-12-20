using PsychologicalAssistance.Core.Data.DTOs;
using PsychologicalAssistance.Core.Data.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PsychologicalAssistance.Services.Interfaces
{
    public interface ITrainingService : IBaseService<Training>
    {
        Task<TrainingDto> GetTrainingByIdAsync(int id);
        Task<IEnumerable<TrainingDto>> GetAllTrainingsAsync();
    }
}
