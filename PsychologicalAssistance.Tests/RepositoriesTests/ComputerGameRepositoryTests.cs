using AutoMapper;
using PsychologicalAssistance.Core.Data;
using PsychologicalAssistance.Core.Data.Entities;
using PsychologicalAssistance.Core.Data.Helpers.AutoMapper;
using PsychologicalAssistance.Core.Enums;
using PsychologicalAssistance.Core.Repositories.Implementation;
using PsychologicalAssistance.Tests.Common;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace PsychologicalAssistance.Tests.RepositoriesTests
{
    public class ComputerGameRepositoryTests : InMemoryDatabaseCreation
    {
        private readonly IMapper _mapper;
        public ComputerGameRepositoryTests()
        {
            Setup();
            _mapper = BasicClassForMocking.ConfigMapper(new ComputerGameProfile());
        }

        [Fact]
        public async Task ComputerGameRepository_GetAllComputerGame_ReturnAllValues()
        {
            using (var context = new ApplicationDbContext(dbContextOptions))
            {
                //arrange
                var computerGameRepository = new ComputerGameRepository(context, _mapper);

                //act
                var computerGames = await computerGameRepository.GetAllComputerGamesDtoAsync();

                //assert
                Assert.NotNull(computerGames.ToList());
                Assert.Equal(4, computerGames.ToList().Count);
            

            }
        }
       
        [Fact]

        public async Task ComputerGameRepository_GetComputerGameById_ReturnValueById()
        {
            using (var context = new ApplicationDbContext(dbContextOptions))
            {
                //arrange
                int id = 2;
                var computerGameRepository = new ComputerGameRepository(context, _mapper);

                //act
                var computerGame = await computerGameRepository.GetComputerGameByIdDtoAsync(id);

                //assert
                Assert.NotNull(computerGame);
                Assert.Equal("Rockstar", computerGame.Company);
                Assert.Equal("ActionAdventure", computerGame.Genre);
                Assert.Equal("EN", computerGame.Language);
                Assert.Equal("97/100", computerGame.Review);
            }
        }


    }
}
