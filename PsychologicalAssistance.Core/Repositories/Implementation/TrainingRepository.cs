using AutoMapper;
using PsychologicalAssistance.Core.Data;
using PsychologicalAssistance.Core.Data.DTOs;
using PsychologicalAssistance.Core.Data.Entities;
using PsychologicalAssistance.Core.Repositories.Abstract;
using PsychologicalAssistance.Core.Repositories.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PsychologicalAssistance.Core.Repositories.Implementation
{
    public class TrainingRepository : DataRepository<Training>, ITrainingRepository
    {
        private readonly IMapper _mapper;

        public TrainingRepository(ApplicationDbContext dbContext, IMapper mapper) : base(dbContext)
        {
            _mapper = mapper;
        }

        public async Task<IEnumerable<TrainingDto>> GetAllTrainingsDtoAsync()
        {
            var trainings = await GetAllItemsAsync();
            if (trainings == null)
            {
                return null;
            }

            var trainingsDto = _mapper.Map<IEnumerable<Training>, IEnumerable<TrainingDto>>(trainings);
            return trainingsDto;
        }

        public async Task<TrainingDto> GetTrainingByIdDtoAsync(int id)
        {
            var training = await GetItemByIdAsync(id);
            if (training == null)
            {
                return null;
            }

            var trainingDto = _mapper.Map<Training, TrainingDto>(training);
            return trainingDto;
        }
    }
}
