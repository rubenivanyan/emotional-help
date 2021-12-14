using PsychologicalAssistance.Core.Data.DTOs;
using PsychologicalAssistance.Core.Data.Entities;
using System.Threading.Tasks;

namespace PsychologicalAssistance.Services.Interfaces
{
    public interface IMaterialsRecommendationService
    {
        Task<MaterialsRecommendationsDto> GetMaterialsRecommendationsForUserAsync(User user, int testResultsId);
    }
}
