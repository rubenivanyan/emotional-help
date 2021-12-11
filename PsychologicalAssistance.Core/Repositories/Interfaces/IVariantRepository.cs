using PsychologicalAssistance.Core.Data.DTOs;
using PsychologicalAssistance.Core.Data.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PsychologicalAssistance.Core.Repositories.Interfaces
{
    public interface IVariantRepository : IDataRepository<Variant>
    {
        public Task<IEnumerable<VariantDto>> GetAllVariantsDtoAsync();
        public Task<VariantDto> GetVariantDtoAsync(int id);
    }
}
