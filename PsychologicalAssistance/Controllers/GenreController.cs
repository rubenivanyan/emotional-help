using Microsoft.AspNetCore.Mvc;
using PsychologicalAssistance.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PsychologicalAssistance.Web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GenreController : ControllerBase
    {
        private readonly IGenreService _genreService;

        public GenreController(IGenreService genreService)
        {
            _genreService = genreService;
        }

        [HttpGet]
        public async Task<ActionResult> GetAllGenres()
        {
            var genres = await _genreService.GetAllGenresAsync();
            return genres is not null ? Ok(genres) : NotFound();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> GetGenreById(int id)
        {
            var genre = await _genreService.GetGenreByIdAsync(id);
            return genre is not null ? Ok(genre) : NotFound();
        }
    }
}
