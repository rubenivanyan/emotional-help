using PsychologicalAssistance.Core.Data.DTOs;
using PsychologicalAssistance.Core.Data.Entities;
using PsychologicalAssistance.Core.Repositories.Interfaces;
using PsychologicalAssistance.Services.Abstract;
using PsychologicalAssistance.Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PsychologicalAssistance.Services.Implementation
{
    public class TrainingApplicationService : BaseService<TrainingApplication>, ITrainingApplicationService
    {
        private readonly ITrainingApplicationRepository _trainingApplicationRepository;

        public TrainingApplicationService(IDataRepository<TrainingApplication> dataRepository, ITrainingApplicationRepository trainingApplicationRepository, IUnitOfWork unitOfWork) : base(dataRepository, unitOfWork)
        {
            _trainingApplicationRepository = trainingApplicationRepository;
        }

        public async Task<IEnumerable<FullTrainingApplicationDto>> GetAllTrainingApplicationsAsync()
            => await _trainingApplicationRepository.GetAllTrainingApplicationsDtoAsync();

        public async Task<FullTrainingApplicationDto> GetTrainingApplicationByIdAsync(int id)
            => await _trainingApplicationRepository.GetTrainingApplicationDtoByIdAsync(id);
    }
}
