using PsychologicalAssistance.Core.Data.DTOs;
using PsychologicalAssistance.Core.Data.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PsychologicalAssistance.Services.Interfaces
{
    public interface IVariantService : IBaseService<Variant>
    {
        Task<IEnumerable<VariantDto>> GetAllVariantsDtoAsync();
        Task<VariantDto> GetVariantByIdDtoAsync(int id);
        Task AddVariantToQuestion(int questionId, int variantId);
    }
}
