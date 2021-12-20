using AutoMapper;
using PsychologicalAssistance.Core.Data;
using PsychologicalAssistance.Core.Data.Entities;
using PsychologicalAssistance.Core.Data.Helpers.AutoMapper;
using PsychologicalAssistance.Core.Repositories.Implementation;
using PsychologicalAssistance.Tests.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace PsychologicalAssistance.Tests.RepositoriesTests
{
    public class TrainingRepositoryTests : InMemoryDatabaseCreation
    {
        private readonly IMapper _mapper;

        public TrainingRepositoryTests()
        {
            Setup();
            _mapper = BasicClassForMocking.ConfigMapper(new TrainingProfile());
        }

        [Fact]
        public async Task TrainingRepository_GetAllTrainings_ReturnAllValues()
        {
            using (var context = new ApplicationDbContext(dbContextOptions))
            {
                //arrange
                var trainingRepository = new TrainingRepository(context, _mapper);

                //act
                var trainings = await trainingRepository.GetAllTrainingsDtoAsync();

                //assert
                Assert.NotNull(trainings.ToList());
                Assert.Equal(6, trainings.ToList().Count);
                Assert.Equal("Mistakes in relationships", trainings.Select(b => b.Title).First());
            }
        }

        [Fact]
        public async Task TrainingRepository_GetTrainingById_ReturnValueById()
        {
            using (var context = new ApplicationDbContext(dbContextOptions))
            {
                //arrange
                int id = 1;
                var trainingRepository = new TrainingRepository(context, _mapper);

                //act
                var training = await trainingRepository.GetTrainingByIdDtoAsync(id);

                //assert
                Assert.NotNull(training);
                Assert.Equal("Time management: effective time management tools", training.Title);
                Assert.Equal(new DateTime(20 / 12 / 2021), training.StartDate);
                Assert.Equal("The training is designed for a wide range of listeners and is recommended for anyone who wants to increase personal efficiency.", training.Description);
            }
        }

        [Fact]
        public async Task TrainingRepository_GetTrainingById()
        {
            using (var context = new ApplicationDbContext(dbContextOptions))
            {
                //arrange
                int id = 1;
                var trainingRepository = new TrainingRepository(context, _mapper);

                //act
                var training = await trainingRepository.GetTrainingByIdDtoAsync(id);

                //assert
                var expected = ExpectedTrainings.FirstOrDefault(x => x.Id == id);
                Assert.Equal(expected.Id, training.Id);
                Assert.NotNull(training);
            }
        }

        private static IEnumerable<Training> ExpectedTrainings =>
           new[]
           {
               new Training
               {
                   Id = 1,
                   Title = "Time management: effective time management tools",
                   Description = "The training is designed for a wide range of listeners and is recommended for anyone who wants to increase personal efficiency.",
                   StartDate = new DateTime(20 / 12 / 2021)
               },
               new Training
               {
                   Id = 2,
                   Title = "Emotional intelligence. Emotion control and management",
                   Description = "The training will be useful for everyone who communicates with clients, partners and visitors of the company; who works in conditions of emotional pressure, who needs to be able to regulate their own emotional state in the course of complex communications.",
                   StartDate = new DateTime(21 / 12 / 2021)
               }
           };
    }
}
