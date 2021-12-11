using AutoMapper;
using PsychologicalAssistance.Core.Data;
using PsychologicalAssistance.Core.Data.DTOs;
using PsychologicalAssistance.Core.Data.Entities;
using PsychologicalAssistance.Core.Data.Helpers.AutoMapper;
using PsychologicalAssistance.Core.Repositories.Abstract;
using PsychologicalAssistance.Core.Repositories.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PsychologicalAssistance.Core.Repositories.Implementation
{
    public class VariantRepository : DataRepository<Variant>, IVariantRepository
    {
        private readonly IMapper _mapper;

        public VariantRepository(ApplicationDbContext dbContext, IMapper mapper) : base(dbContext)
        {
            _mapper = mapper;
        }

        public async Task<IEnumerable<VariantDto>> GetAllVariantsDtoAsync()
        {
            var variants = await GetAllItemsAsync();
            if (variants == null)
            {
                return null;
            }

            var variantsDto = MapCollections.MapCollection<Variant, VariantDto>(variants, _mapper);
            return variantsDto;
        }

        public async Task<VariantDto> GetVariantDtoAsync(int id)
        {
            var variant = await GetItemByIdAsync(id);
            if (variant == null)
            {
                return null;
            }

            var variantDto = _mapper.Map<Variant, VariantDto>(variant);
            return variantDto;
        }
    }
}
