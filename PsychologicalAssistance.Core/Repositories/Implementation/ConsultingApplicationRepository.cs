using AutoMapper;
using PsychologicalAssistance.Core.Data;
using PsychologicalAssistance.Core.Data.DTOs;
using PsychologicalAssistance.Core.Data.Entities;
using PsychologicalAssistance.Core.Repositories.Abstract;
using PsychologicalAssistance.Core.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PsychologicalAssistance.Core.Repositories.Implementation
{
    public class ConsultingApplicationRepository : DataRepository<ConsultingApplication>, IConsultingApplicationRepository
    {
        private readonly IMapper _mapper;

        public ConsultingApplicationRepository(ApplicationDbContext dbContext, IMapper mapper) : base(dbContext)
        {
            _mapper = mapper;
        }

        public async Task<IEnumerable<ConsultingApplicationDto>> GetAllConsultingApplicationsDtoAsync()
        {
            var consultingApplications = await GetAllItemsAsync();
            if (consultingApplications == null)
            {
                return null;
            }

            var consultingApplicationsDto = _mapper.Map<IEnumerable<ConsultingApplication>, IEnumerable<ConsultingApplicationDto>>(consultingApplications);
            return consultingApplicationsDto;
        }

        public async Task<ConsultingApplicationDto> GetConsultingApplicationByIdDtoAsync(int id)
        {
            var consultingApplication = await GetItemByIdAsync(id);
            if (consultingApplication == null)
            {
                return null;
            }

            var consultingApplicationDto = _mapper.Map<ConsultingApplication, ConsultingApplicationDto>(consultingApplication);
            return consultingApplicationDto;
        }
    }
}
