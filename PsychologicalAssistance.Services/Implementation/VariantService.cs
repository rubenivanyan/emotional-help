using PsychologicalAssistance.Core.Data.DTOs;
using PsychologicalAssistance.Core.Data.Entities;
using PsychologicalAssistance.Core.Repositories.Interfaces;
using PsychologicalAssistance.Services.Abstract;
using PsychologicalAssistance.Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PsychologicalAssistance.Services.Implementation
{
    public class VariantService : BaseService<Variant>, IVariantService
    {
        private readonly IVariantRepository _variantRepository;

        public VariantService(IDataRepository<Variant> dataRepository, IUnitOfWork unitOfWork, IVariantRepository variantRepository)
            : base(dataRepository, unitOfWork)
        {
            _variantRepository = variantRepository;
        }

        public async Task<IEnumerable<VariantDto>> GetAllVariantsDtoAsync()
            => await _variantRepository.GetAllVariantsDtoAsync();

        public async Task<VariantDto> GetVariantByIdDtoAsync(int id)
            => await _variantRepository.GetVariantDtoAsync(id);
    }
}