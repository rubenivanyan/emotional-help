﻿using AutoMapper;
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
    public class TrainingController : ControllerBase
    {
        private readonly ITrainingService _trainingService;
        private readonly IMapper _mapper;

        public TrainingController(ITrainingService trainingService, IMapper mapper)
        {
            _trainingService = trainingService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult> GetAllTrainings()
        {
            var trainings = await _trainingService.GetAllTrainingsAsync();
            return trainings is not null ? Ok(trainings) : NotFound();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> GetTrainingById(int id)
        {
            var training = await _trainingService.GetTrainingByIdAsync(id);
            return training is not null ? Ok(training) : NotFound();
        }

        [HttpPost]
        [Authorize(Roles = "Administrator")]
        public async Task<ActionResult> CreateTraining([FromBody] TrainingDto trainingDto)
        {
            var training = _mapper.Map<TrainingDto, Training>(trainingDto);
            await _trainingService.CreateAsync(training);
            return Ok();
        }

        [HttpPut]
        [Authorize(Roles = "Administrator")]
        public async Task<ActionResult> UpdateTraining([FromBody] TrainingDto trainingDto)
        {
            var training = _mapper.Map<TrainingDto, Training>(trainingDto);
            await _trainingService.UpdateAsync(training);
            return NoContent();
        }

        [HttpDelete("{id}")]
        [Authorize(Roles = "Administrator")]
        public async Task<ActionResult> DeleteTraining(int id)
        {
            var isSucceed = await _trainingService.DeleteAsync(id);
            return isSucceed ? NoContent() : NotFound("Id does not exist");
        }
    }
}
