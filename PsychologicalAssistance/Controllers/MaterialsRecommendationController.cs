using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PsychologicalAssistance.Core.Data.Entities;
using PsychologicalAssistance.Services.Interfaces;
using System.Threading.Tasks;

namespace PsychologicalAssistance.Web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MaterialsRecommendationController : ControllerBase
    {
        private readonly IMaterialsRecommendationService _materialsRecommendationService;
        private readonly UserManager<User> _userManager;

        public MaterialsRecommendationController(IMaterialsRecommendationService materialsRecommendationService, UserManager<User> userManager)
        {
            _materialsRecommendationService = materialsRecommendationService;
            _userManager = userManager;
        }

        [HttpGet("{testResultsId}")]
        [Authorize]
        public async Task<ActionResult> GetRecommendationsByTestResultsId(int testResultsId)
        {
            var user = await _userManager.GetUserAsync(User);
            var materials = await _materialsRecommendationService.GetMaterialsRecommendationsForUserAsync(user, testResultsId);
            return materials is not null ? Ok(materials) : NotFound();
        }
    }
}
