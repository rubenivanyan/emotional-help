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
    public class TrainingApplicationController : ControllerBase
    {
        private readonly ITrainingApplicationService _trainingApplicationService;
        private readonly IMapper _mapper;
        private readonly UserManager<User> _userManager;


        public TrainingApplicationController(ITrainingApplicationService trainingApplicationService, IMapper mapper, UserManager<User> userManager)
        {
            _trainingApplicationService = trainingApplicationService;
            _mapper = mapper;
            _userManager = userManager;
        }

        [HttpGet]
        [Authorize(Roles = "Administrator")]
        public async Task<ActionResult> GetAllTrainingApplications()
        {
            var trainingApplications = await _trainingApplicationService.GetAllTrainingApplicationsAsync();
            return trainingApplications is not null ? Ok(trainingApplications) : NotFound();
        }

        [HttpGet("{id}")]
        [Authorize(Roles = "Administrator")]
        public async Task<ActionResult> GetTrainingApplicationById(int id)
        {
            var trainingApplication = await _trainingApplicationService.GetTrainingApplicationByIdAsync(id);
            return trainingApplication is not null ? Ok(trainingApplication) : NotFound();
        }

        [HttpGet("userId")]
        [Authorize]
        public async Task<ActionResult> GetTrainingApplicationByUserId()
        {
            var userId = _userManager.GetUserId(HttpContext.User);
            var trainingApplication = await _trainingApplicationService.GetTrainingApplicationByUserIdAsync(userId);
            return trainingApplication is not null ? Ok(trainingApplication) : NotFound();
        }


        [HttpPost]
        [Authorize]
        public async Task<ActionResult> CreateTrainingApplication([FromBody] TrainingApplicationDto trainingApplicationDto)
        {
            var trainingApplication = _mapper.Map<TrainingApplication>(trainingApplicationDto);
            var userId = _userManager.GetUserId(HttpContext.User);
            trainingApplication.UserId = userId;
            await _trainingApplicationService.CreateAsync(trainingApplication);
            return Ok();
        }

        [HttpDelete("{id}")]
        [Authorize]
        public async Task<ActionResult> DeleteTrainingApplication(int id)
        {
            await _trainingApplicationService.DeleteAsync(id);
            return NoContent();
        }
    }
}
