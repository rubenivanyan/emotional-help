using PsychologicalAssistance.Core.Data.DTOs;
using PsychologicalAssistance.Core.Data.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PsychologicalAssistance.Core.Repositories.Interfaces
{
    public interface ITrainingRepository : IDataRepository<Training>
    {
        Task<IEnumerable<TrainingDto>> GetAllTrainingsDtoAsync();
        Task<TrainingDto> GetTrainingByIdDtoAsync(int id);
    }
}
