using AutoMapper;
using Microsoft.EntityFrameworkCore;
using PsychologicalAssistance.Core.Data;
using PsychologicalAssistance.Core.Data.DTOs;
using PsychologicalAssistance.Core.Data.Entities;
using PsychologicalAssistance.Core.Repositories.Abstract;
using PsychologicalAssistance.Core.Repositories.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PsychologicalAssistance.Core.Repositories.Implementation
{
    public class TrainingApplicationRepository : DataRepository<TrainingApplication>, ITrainingApplicationRepository
    {
        private readonly IMapper _mapper;

        public TrainingApplicationRepository(ApplicationDbContext dbContext, IMapper mapper) : base(dbContext)
        {
            _mapper = mapper;
        }

        public async Task<IEnumerable<FullTrainingApplicationDto>> GetAllTrainingApplicationsDtoAsync()
        {
            var trainingApplications = await Task.Run(() => DbSet
                .Include(i => i.User).Include(i => i.Training)
            );

            if (trainingApplications == null)
            {
                return null;
            }

            var trainingApplicationsDto = _mapper.Map<IEnumerable<TrainingApplication>, IEnumerable<FullTrainingApplicationDto>>(trainingApplications);
            return trainingApplicationsDto;
        }

        public async Task<FullTrainingApplicationDto> GetTrainingApplicationDtoByIdAsync(int id)
        {
            var trainingApplication = await Task.Run(() => DbSet
                .Where(i => i.Id == id)
                .Include(i => i.User).Include(i => i.Training)
                .FirstOrDefault()
            );

            if (trainingApplication == null)
            {
                return null;
            }

            var trainingApplicationDto = _mapper.Map<TrainingApplication, FullTrainingApplicationDto>(trainingApplication);
            return trainingApplicationDto;
        }

        public async Task<IEnumerable<FullTrainingApplicationDto>> GetTrainingApplicationDtoByUserIdAsync(string id)
        {
            var trainingApplication = await Task.Run(() => DbSet
                   .Where(i => i.UserId == id)
                   .Include(i => i.User).Include(i => i.Training)
                   .ToList()
               );

            if (trainingApplication == null)
            {
                return null;
            }
            var trainingApplicationDto = _mapper.Map<IEnumerable<TrainingApplication>, IEnumerable<FullTrainingApplicationDto>>(trainingApplication);
            return trainingApplicationDto;
        }
    }
}
