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
    public class MusicController : ControllerBase
    {
        private readonly IMusicService _musicService;
        private readonly IMapper _mapper;

        public MusicController(IMusicService musicService, IMapper mapper)
        {
            _musicService = musicService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult> GetAllMusics()
        {
            var musics = await _musicService.GetAllMusicsAsync();
            return musics is not null ? Ok(musics) : NotFound();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> GetMusicById(int id)
        {
            var music = await _musicService.GetMusicByIdAsync(id);
            return music is not null ? Ok(music) : NotFound();
        }

        [HttpPost]
        [Authorize(Roles = "Administrator")]
        public async Task<ActionResult> CreateMusic([FromBody] MusicDto musicDto)
        {
            var music = _mapper.Map<Music>(musicDto);
            await _musicService.CreateAsync(music);
            return Ok();
        }

        [HttpPut]
        [Authorize(Roles = "Administrator")]
        public async Task<ActionResult> UpdateMusic([FromBody] MusicDto musicDto)
        {
            var music = _mapper.Map<Music>(musicDto);
            await _musicService.UpdateAsync(music);
            return NoContent();
        }

        [HttpDelete("{id}")]
        [Authorize(Roles = "Administrator")]
        public async Task<ActionResult> DeleteMusic(int id)
        {
            await _musicService.DeleteAsync(id);
            return NoContent();
        }
    }
}
