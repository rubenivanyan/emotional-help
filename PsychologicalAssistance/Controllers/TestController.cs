using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PsychologicalAssistance.Core.Data.DTOs;
using PsychologicalAssistance.Core.Data.Entities;
using PsychologicalAssistance.Services.Interfaces;
using System.Threading.Tasks;

namespace PsychologicalAssistance.Web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TestController : ControllerBase
    {
        private readonly ITestService _testService;
        private readonly IMapper _mapper;

        public TestController(ITestService testService, IMapper mapper)
        {
            _testService = testService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult> GetAllTests()
        {
            var tests = await _testService.GetAllTestsAsync();
            return tests is not null ? Ok(tests) : NotFound();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> GetTestById(int id)
        {
            var test = await _testService.GetTestByIdAsync(id);
            return test is not null ? Ok(test) : NotFound();
        }

        [HttpPost]
        public async Task<ActionResult> CreateTest([FromBody] TestDto testDto)
        {
            //TODO Check if object already exists
            var test = _mapper.Map<Test>(testDto);
            await _testService.CreateAsync(test);
            return Ok();
        }

        [HttpPut]
        public async Task<ActionResult> UpdateTest([FromBody] TestDto testDto)
        {
            var test = _mapper.Map<Test>(testDto);
            await _testService.UpdateAsync(test);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteTest(int id)
        {
            await _testService.DeleteAsync(id);
            return NoContent();
        }
    }
}
