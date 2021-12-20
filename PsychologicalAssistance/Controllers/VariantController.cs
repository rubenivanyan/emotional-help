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
    public class VariantController : ControllerBase
    {
        private readonly IVariantService _variantService;
        private readonly IMapper _mapper;

        public VariantController(IVariantService variantService, IMapper mapper)
        {
            _variantService = variantService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult> GetAllVariants()
        {
            var variants = await _variantService.GetAllVariantsDtoAsync();
            return variants is not null ? Ok(variants) : NotFound();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> GetVariantById(int id)
        {
            var variant = await _variantService.GetVariantByIdDtoAsync(id);
            return variant is not null ? Ok(variant) : NotFound();
        }

        [HttpGet("with-genres")]
        public async Task<ActionResult> GetAllVariantsWithGenres()
        {
            var variants = await _variantService.GetAllVariantsWithGenresAsync();
            return variants is not null ? Ok(variants) : NotFound();
        }

        [HttpGet("{id}/with-genres")]
        public async Task<ActionResult> GetVariantWithGenresById(int id)
        {
            var variant = await _variantService.GetVariantWithGenresByIdAsync(id);
            return variant is not null ? Ok(variant) : NotFound();
        }

        [HttpPost]
        [Authorize(Roles = "Administrator")]
        public async Task<ActionResult> CreateVariant([FromBody] VariantDto variantDto)
        {
            var variant = _mapper.Map<VariantDto, Variant>(variantDto);
            await _variantService.CreateAsync(variant);
            return Ok();
        }

        [HttpPost("{questionId} {variantId}")]
        [Authorize(Roles = "Administrator")]
        public async Task<ActionResult> AddVariantToQuestion(int questionId, int variantId)
        {
            await _variantService.AddVariantToQuestion(questionId, variantId);
            return Ok();
        }

        [HttpPut]
        [Authorize(Roles = "Administrator")]
        public async Task<ActionResult> UpdateVariant([FromBody] VariantDto variantDto)
        {
            var variant = _mapper.Map<VariantDto, Variant>(variantDto);
            await _variantService.UpdateAsync(variant);
            return NoContent();
        }

        [HttpDelete("{id}")]
        [Authorize(Roles = "Administrator")]
        public async Task<ActionResult> DeleteVariant(int id)
        {
            await _variantService.DeleteAsync(id);
            return NoContent();
        }
    }
}
