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
    public class ApplicationRepositoryTests : InMemoryDatabaseCreation
    {
        private readonly IMapper _mapper;
        public ApplicationRepositoryTests()
        {
            Setup();
            _mapper = BasicClassForMocking.ConfigMapper(new ApplicationProfile());
        }

        [Fact]
        public async Task GetAllApplicationsDtoAsync_ReturnsListOfApplicationDto()
        {
            //arrange
            using (var dbContext = new ApplicationDbContext(dbContextOptions))
            {
                var repository = new ApplicationRepository(dbContext, _mapper);

                //act
                var result = await repository.GetAllApplicationsDtoAsync();

                //assert
                Assert.NotNull(result);
                Assert.IsType<List<ApplicationDto>>(result);
            }
        }
    }
}
