using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PsychologicalAssistance.Core.Data.DTOs;
using PsychologicalAssistance.Core.Data.Entities;
using PsychologicalAssistance.Services.Interfaces;
using System.Threading.Tasks;

namespace PsychologicalAssistance.Web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ApplicationController : ControllerBase
    {
        private readonly IApplicationService _applicationService;
        private readonly IMapper _mapper;

        public ApplicationController(IApplicationService applicationService, IMapper mapper)
        {
            _applicationService = applicationService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult> GetAllApplications()
        {
            var applications = await _applicationService.GetAllApplicationsAsync();
            return applications is not null ? Ok(applications) : NotFound();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> GetApplicationById(int id)
        {
            var application = await _applicationService.GetApplicationByIdAsync(id);
            return application is not null ? Ok(application) : NotFound();
        }

        [HttpGet("{id}/full")]
        public async Task<ActionResult> GetFullApplicationById(int id)
        {
            var fullApplication = await _applicationService.GetFullApplicationDtoByIdAsync(id);
            return fullApplication is not null ? Ok(fullApplication) : NotFound();
        }

        [HttpPost]
        public async Task<ActionResult> CreateApplication([FromBody] ApplicationDto applicationDto)
        {
            var application = _mapper.Map<Application>(applicationDto);
            await _applicationService.CreateAsync(application);
            return Ok();
        }

        [HttpPut]
        public async Task<ActionResult> UpdateApplication([FromBody] ApplicationDto applicationDto)
        {
            var application = _mapper.Map<Application>(applicationDto);
            await _applicationService.UpdateAsync(application);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteApplication(int id)
        {
            await _applicationService.DeleteAsync(id);
            return NoContent();
        }
    }
}
