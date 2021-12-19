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
    public class ComputerGameController : ControllerBase
    {
        private readonly IComputerGameService _computerGameService;
        private readonly IMapper _mapper;

        public ComputerGameController(IComputerGameService computerGameService, IMapper mapper)
        {
            _computerGameService = computerGameService;
            _mapper = mapper;
        }

        [HttpGet]
        [Authorize]
        public async Task<ActionResult> GetAllComputerGames()
        {
            var games = await _computerGameService.GetAllComputerGamesAsync();
            return games is not null ? Ok(games) : NotFound();
        }

        [HttpGet("{id}")]
        [Authorize]
        public async Task<ActionResult> GetComputerGameById(int id)
        {
            var game = await _computerGameService.GetComputerGameByIdAsync(id);
            return game is not null ? Ok(game) : NotFound();
        }

        [HttpPost]
        [Authorize(Roles = "Administrator")]
        public async Task<ActionResult> CreateComputerGame([FromBody] ComputerGameDto gameDto)
        {
            var game = _mapper.Map<ComputerGame>(gameDto);
            await _computerGameService.CreateAsync(game);
            return Ok();
        }

        [HttpPut]
        [Authorize(Roles = "Administrator")]
        public async Task<ActionResult> UpdateComputerGame([FromBody] ComputerGameDto gameDto)
        {
            var game = _mapper.Map<ComputerGame>(gameDto);
            await _computerGameService.UpdateAsync(game);
            return NoContent();
        }

        [HttpDelete("{id}")]
        [Authorize(Roles = "Administrator")]
        public async Task<ActionResult> DeleteComputerGame(int id)
        {
            await _computerGameService.DeleteAsync(id);
            return NoContent();
        }
    }
}
