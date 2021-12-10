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
    public class ApplicationRepository : DataRepository<Application>, IApplicationRepository
    {
        private readonly IMapper _mapper;

        public ApplicationRepository(ApplicationDbContext dbContext, IMapper mapper) : base (dbContext)
        {
            _mapper = mapper;
        }

        public async Task<IEnumerable<ApplicationDto>> GetAllApplicationsDtoAsync()
        {
            var applications = await GetAllItemsAsync();
            if (applications == null)
            {
                return null;
            }

            var applicationsDto = new List<ApplicationDto>();
            foreach (var application in applications)
            {
                applicationsDto.Add(_mapper.Map<ApplicationDto>(application));
            }

            return applicationsDto;
        }

        public async Task<ApplicationDto> GetApplicationByIdDtoAsync(int id)
        {
            var application = await GetItemByIdAsync(id);
            if (application == null)
            {
                return null;
            }

            var applicationDto = _mapper.Map<ApplicationDto>(application);
            return applicationDto;
        }
    }
}
