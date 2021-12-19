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
    public class FilmController : ControllerBase
    {
        private readonly IFilmService _filmService;
        private readonly IMapper _mapper;

        public FilmController(IFilmService filmService, IMapper mapper)
        {
            _filmService = filmService;
            _mapper = mapper;
        }

        [HttpGet]
        [Authorize]
        public async Task<ActionResult> GetAllFilms()
        {
            var films = await _filmService.GetAllFilmsAsync();
            return films is not null ? Ok(films) : NotFound();
        }

        [HttpGet("{id}")]
        [Authorize]
        public async Task<ActionResult> GetFilmById(int id)
        {
            var film = await _filmService.GetFilmByIdAsync(id);
            return film is not null ? Ok(film) : NotFound();
        }

        [HttpPost]
        [Authorize(Roles = "Administrator")]
        public async Task<ActionResult> CreateFilm([FromBody] FilmDto filmDto)
        {
            var film = _mapper.Map<FilmDto, Film>(filmDto);
            await _filmService.CreateAsync(film);
            return Ok();
        }

        [HttpPut]
        [Authorize(Roles = "Administrator")]
        public async Task<ActionResult> UpdateFilm([FromBody] FilmDto filmDto)
        {
            var film = _mapper.Map<FilmDto, Film>(filmDto);
            await _filmService.UpdateAsync(film);
            return NoContent();
        }

        [HttpDelete("{id}")]
        [Authorize(Roles = "Administrator")]
        public async Task<ActionResult> DeleteFilm(int id)
        {
            await _filmService.DeleteAsync(id);
            return NoContent();
        }
    }
}
