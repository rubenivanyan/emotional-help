using AutoMapper;
using PsychologicalAssistance.Core.Data;
using PsychologicalAssistance.Core.Data.DTOs;
using PsychologicalAssistance.Core.Data.Helpers.AutoMapper;
using PsychologicalAssistance.Core.Repositories.Implementation;
using PsychologicalAssistance.Tests.Common;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace PsychologicalAssistance.Tests.RepositoriesTests
{
    public class TestingApplicationRepositoryTests : InMemoryDatabaseCreation
    {
        private readonly IMapper _mapper;
        public TestingApplicationRepositoryTests()
        {
            Setup();
            _mapper = BasicClassForMocking.ConfigMapper(new TestingApplicationProfile());
        }

        [Fact]
        public async Task GetAllApplicationsDtoAsync_ReturnsListOfApplicationDto()
        {
            //arrange
            using (var dbContext = new ApplicationDbContext(dbContextOptions))
            {
                var repository = new TestingApplicationRepository(dbContext, _mapper);

                //act
                var result = await repository.GetAllTestingApplicationsDtoAsync();

                //assert
                Assert.NotNull(result);
                Assert.IsType<List<TestingApplicationDto>>(result);
            }
        }
    }
}
