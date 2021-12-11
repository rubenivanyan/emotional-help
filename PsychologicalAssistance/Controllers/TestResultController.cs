using AutoMapper;
using Microsoft.AspNetCore.Mvc;
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

        public TestResultController(ITestResultsService testResultsService, IMapper mapper)
        {
            _mapper = mapper;
            _testResultsService = testResultsService;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> GetTestResultsById(int id)
        {
            var testResults = await _testResultsService.GetTestResultsByIdAsync(id);
            return testResults is not null ? Ok(testResults) : NotFound();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteTestResults(int id)
        {
            await _testResultsService.DeleteAsync(id);
            return NoContent();
        }
    }
}
