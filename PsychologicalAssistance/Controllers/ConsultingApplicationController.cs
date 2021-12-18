using AutoMapper;
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
    public class ConsultingApplicationController : ControllerBase
    {
        private readonly IConsultingApplicationService _consultingApplicationService;
        private readonly IMapper _mapper;
        private readonly UserManager<User> _userManager;
                
        public ConsultingApplicationController(IConsultingApplicationService consultingApplicationService, IMapper mapper, UserManager<User> userManager)
        {
            _consultingApplicationService = consultingApplicationService;
            _mapper = mapper;
            _userManager = userManager;
        }

        [HttpGet]
        public async Task<ActionResult> GetAllConsultingApplications()
        {
            var consultingApplications = await _consultingApplicationService.GetAllConsultingApplicationsAsync();
            return consultingApplications is not null ? Ok(consultingApplications) : NotFound();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> GetConsultingApplicationById(int id)
        {
            var consultingApplication = await _consultingApplicationService.GetConsultingApplicationByIdAsync(id);
            return consultingApplication is not null ? Ok(consultingApplication) : NotFound();
        }

        [HttpGet("all")]
        public async Task<ActionResult> GetAllConsultingApplicationsWithUserInfo()
        {
            var consultingApplications = await _consultingApplicationService.GetAllConsultingApplicationsWithUserInfoAsync();
            return consultingApplications is not null ? Ok(consultingApplications) : NotFound();
        }

        [HttpGet("{id}/all")]
        public async Task<ActionResult> GetConsultingApplicationWithUserInfoById(int id)
        {
            var consultingApplication = await _consultingApplicationService.GetConsultingApplicationWithUserInfoByIdAsync(id);
            return consultingApplication is not null ? Ok(consultingApplication) : NotFound();
        }

        [HttpGet("userId")]
        public async Task<ActionResult> GetConsultingApplicationWithUserInfoByUserId()
        {
            var userId = _userManager.GetUserId(HttpContext.User);
            var consultingApplication = await _consultingApplicationService.GetConsultingApplicationWithUserInfoByUserIdAsync(userId);
            return consultingApplication is not null ? Ok(consultingApplication) : NotFound();
        }

        [HttpPost]
        public async Task<ActionResult> CreateConsultingApplication([FromBody] ConsultingApplicationDto consultingApplicationDto)
        {
            var consultingApplication = _mapper.Map<ConsultingApplicationDto, ConsultingApplication>(consultingApplicationDto);
            var userId = _userManager.GetUserId(HttpContext.User);
            consultingApplication.UserId = userId;
            await _consultingApplicationService.CreateAsync(consultingApplication);
            return Ok();
        }

        [HttpPut]
        public async Task<ActionResult> UpdateConsultingApplication([FromBody] ConsultingApplicationDto consultingApplicationDto)
        {
            var consultingApplication = _mapper.Map<ConsultingApplicationDto, ConsultingApplication>(consultingApplicationDto);
            var userId = _userManager.GetUserId(HttpContext.User);
            consultingApplication.UserId = userId;
            await _consultingApplicationService.UpdateAsync(consultingApplication);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteConsultingApplication(int id)
        {
            await _consultingApplicationService.DeleteAsync(id);
            return NoContent();
        }
    }
}
