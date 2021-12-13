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
    public class QuestionController : ControllerBase
    {
        private readonly IQuestionService _questionService;
        private readonly IMapper _mapper;

        public QuestionController(IQuestionService questionService, IMapper mapper)
        {
            _questionService = questionService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult> GetAllQuestions()
        {
            var questions = await _questionService.GetAllQuestionsAsync();
            return questions is not null ? Ok(questions) : NotFound();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> GetQuestionById(int id)
        {
            var question = await _questionService.GetQuestionByIdAsync(id);
            return question is not null ? Ok(question) : NotFound();
        }

        [HttpGet("all/with-variants")]
        public async Task<ActionResult> GetAllQuestionsWithVariants()
        {
            var questions = await _questionService.GetAllQuestionsAndVariants();
            return questions is not null ? Ok(questions) : NotFound();
        }

        [HttpGet("{id}/with-variants")]
        public async Task<ActionResult> GetQuestionWithVariantsById(int id)
        {
            var question = await _questionService.GetQuestionAndVariantsByIdAsync(id);
            return question is not null ? Ok(question) : NotFound();
        }

        [HttpPost]
        public async Task<ActionResult> CreateQuestion([FromBody] QuestionDto questionDto)
        {
            var question = _mapper.Map<QuestionDto, Question>(questionDto);
            await _questionService.CreateAsync(question);
            return Ok();
        }

        [HttpPost("{questionId} {testId}")]
        public async Task<ActionResult> AddQuestionToTest(int questionId, int testId)
        {
            await _questionService.AddQuestionToTest(questionId, testId);
            return Ok();
        }

        [HttpPut]
        public async Task<ActionResult> UpdateQuestion([FromBody] QuestionDto questionDto)
        {
            var question = _mapper.Map<QuestionDto, Question>(questionDto);
            await _questionService.UpdateAsync(question);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteAsync(int id)
        {
            await _questionService.DeleteAsync(id);
            return NoContent();
        }
    }
}
