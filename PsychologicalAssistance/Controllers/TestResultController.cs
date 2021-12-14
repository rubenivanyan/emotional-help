using AutoMapper;
using Microsoft.AspNetCore.Http;
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
        private readonly UserManager<User> _userManager;

        public TestResultController(ITestResultsService testResultsService, IMapper mapper, UserManager<User> userManager)
        {
            _mapper = mapper;
            _testResultsService = testResultsService;
            _userManager = userManager;
        }

        [HttpGet]
        public async Task<ActionResult> GetAllTestResults()
        {
            var testsResults = await _testResultsService.GetAllTestsResultsAsync();
            return testsResults is not null ? Ok(testsResults) : NotFound();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> GetTestResultsById(int id)
        {
            var testResults = await _testResultsService.GetTestResultsByIdAsync(id);
            return testResults is not null ? Ok(testResults) : NotFound();
        }

        [HttpPost]
        public async Task<ActionResult> CreateTestResults([FromBody] TestResultsDto testResultsDto)
        {
            var user = await _userManager.GetUserAsync(User);
            await _testResultsService.CreateTestResultsAsync(testResultsDto, user);
            return Ok();
        }

        [HttpPut]
        public async Task<ActionResult> UpdateTestResults([FromBody] TestResultsDto testResultsDto)
        {
            var testResults = _mapper.Map<TestResultsDto, TestResults>(testResultsDto);
            await _testResultsService.UpdateAsync(testResults);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteTestResults(int id)
        {
            await _testResultsService.DeleteAsync(id);
            return NoContent();
        }
    }
}
