using PsychologicalAssistance.Core.Data.DTOs;
using PsychologicalAssistance.Core.Data.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PsychologicalAssistance.Core.Repositories.Interfaces
{
    public interface IVariantRepository : IDataRepository<Variant>
    {
        Task<IEnumerable<VariantDto>> GetAllVariantsDtoAsync();
        Task<VariantDto> GetVariantDtoAsync(int id);
        Task<List<string>> GetGenresTitlesByVariantTitleAsync(string formulation);
    }
}
