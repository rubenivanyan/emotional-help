using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PsychologicalAssistance.Core.Data.DTOs;
using PsychologicalAssistance.Core.Data.Entities;
using PsychologicalAssistance.Services.Interfaces;
using System.Threading.Tasks;

namespace PsychologicalAssistance.Web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TestResultController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly ITestResultsService _testResultsService;
        private readonly IMaterialsRecommendationService _materialsRecommendationService;
        private readonly UserManager<User> _userManager;

        public TestResultController(ITestResultsService testResultsService, IMapper mapper, UserManager<User> userManager,
            IMaterialsRecommendationService materialsRecommendationService)
        {
            _mapper = mapper;
            _testResultsService = testResultsService;
            _userManager = userManager;
            _materialsRecommendationService = materialsRecommendationService;
        }

        [HttpGet]
        [Authorize]
        public async Task<ActionResult> GetAllTestResults()
        {
            var testsResults = await _testResultsService.GetAllTestsResultsAsync();
            return testsResults is not null ? Ok(testsResults) : NotFound();
        }

        [HttpGet("{id}")]
        [Authorize]
        public async Task<ActionResult> GetTestResultsById(int id)
        {
            var testResults = await _testResultsService.GetTestResultsForUserByIdAsync(id);
            return testResults is not null ? Ok(testResults) : NotFound();
        }

        [HttpPost]
        [Authorize]
        public async Task<ActionResult> CreateTestResults([FromBody] TestResultsDto testResultsDto)
        {
            var user = await _userManager.GetUserAsync(User);
            var testResultsId = await _testResultsService.CreateTestResultsAsync(testResultsDto, user);
            return testResultsId != -1 ? Ok(testResultsId) : BadRequest();
        }

        [HttpPost("unauthorized")]
        public async Task<ActionResult> CreateTestResultsForGuest([FromBody] TestResultsDto testResultsDto)
        {
            var testResults = await _testResultsService.CreateTestResultsForGuestAsync(testResultsDto);
            var materialsRecommendations = await _materialsRecommendationService.GetMaterialsRecommendationsForGuestAsync(testResultsDto.ChosenVariants);
            testResults.MaterialsRecommendations = materialsRecommendations;
            return Ok(testResults);
        }

        [HttpPut]
        [Authorize(Roles = "Administrator")]
        public async Task<ActionResult> UpdateTestResults([FromBody] TestResultsDto testResultsDto)
        {
            var testResults = _mapper.Map<TestResultsDto, TestResults>(testResultsDto);
            await _testResultsService.UpdateAsync(testResults);
            return NoContent();
        }

        [HttpDelete("{id}")]
        [Authorize(Roles = "Administrator")]
        public async Task<ActionResult> DeleteTestResults(int id)
        {
            await _testResultsService.DeleteAsync(id);
            return NoContent();
        }
    }
}
