using PsychologicalAssistance.Core.Data.DTOs;
using PsychologicalAssistance.Core.Data.Enitities;
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
    public class ApplicationService : BaseService<Application>, IApplicationService
    {
        private readonly IApplicationRepository _applicationRepository;

        public ApplicationService(IDataRepository<Application> dataRepository, IUnitOfWork unitOfWork, IApplicationRepository applicationRepository)
            : base (dataRepository, unitOfWork)
        {
            _applicationRepository = applicationRepository;
        }

        public async Task<IEnumerable<ApplicationDto>> GetAllApplicationsAsync()
            => await _applicationRepository.GetAllApplicationsDtoAsync();

        public async Task<ApplicationDto> GetApplicationByIdAsync(int id)
            => await _applicationRepository.GetApplicationByIdDtoAsync(id);
    }
}
