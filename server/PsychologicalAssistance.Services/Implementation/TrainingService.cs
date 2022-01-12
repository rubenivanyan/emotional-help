using PsychologicalAssistance.Core.Data.DTOs;
using PsychologicalAssistance.Core.Data.Entities;
using PsychologicalAssistance.Core.Repositories.Interfaces;
using PsychologicalAssistance.Services.Abstract;
using PsychologicalAssistance.Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PsychologicalAssistance.Services.Implementation
{
    public class TrainingService : BaseService<Training>, ITrainingService
    {
        private readonly ITrainingRepository _trainingRepository;

        public TrainingService(IDataRepository<Training> dataRepository, ITrainingRepository trainingRepository, IUnitOfWork unitOfWork)
            : base(dataRepository, unitOfWork)
        {
            _trainingRepository = trainingRepository;
        }

        public async Task<IEnumerable<TrainingDto>> GetAllTrainingsAsync()
            => await _trainingRepository.GetAllTrainingsDtoAsync();

        public async Task<TrainingDto> GetTrainingByIdAsync(int id)
            => await _trainingRepository.GetTrainingByIdDtoAsync(id);
    }
}
