using PsychologicalAssistance.Core.Data.DTOs;
using PsychologicalAssistance.Core.Data.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PsychologicalAssistance.Services.Interfaces
{
    public interface IMaterialsRecommendationService
    {
        Task<MaterialsRecommendationsDto> GetMaterialsRecommendationsForUserAsync(User user, int testResultsId);
        Task<MaterialsRecommendationsDto> GetMaterialsRecommendationsForGuestAsync(List<VariantDto> chosenVariants);
    }
}
