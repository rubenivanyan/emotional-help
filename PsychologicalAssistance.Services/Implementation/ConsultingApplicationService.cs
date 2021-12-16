using PsychologicalAssistance.Core.Data.DTOs;
using PsychologicalAssistance.Core.Data.Entities;
using PsychologicalAssistance.Core.Repositories.Abstract;
using PsychologicalAssistance.Core.Repositories.Interfaces;
using PsychologicalAssistance.Services.Abstract;
using PsychologicalAssistance.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PsychologicalAssistance.Services.Implementation
{
    public class ConsultingApplicationService : BaseService<ConsultingApplication>, IConsultingApplicationService
    {
        private readonly IConsultingApplicationRepository _consultingApplicationRepository;
        
        public ConsultingApplicationService(IDataRepository<ConsultingApplication> dataRepository, IUnitOfWork unitOfWork,
            IConsultingApplicationRepository consultingApplicationRepository)
            : base(dataRepository, unitOfWork)
        {
            _consultingApplicationRepository = consultingApplicationRepository;
        }

        public async Task<IEnumerable<ConsultingApplicationDto>> GetAllConsultingApplicationsAsync()
            => await _consultingApplicationRepository.GetAllConsultingApplicationsDtoAsync();

        public async Task<ConsultingApplicationDto> GetConsultingApplicationByIdAsync(int id)
            => await _consultingApplicationRepository.GetConsultingApplicationByIdDtoAsync(id);
    }
}
