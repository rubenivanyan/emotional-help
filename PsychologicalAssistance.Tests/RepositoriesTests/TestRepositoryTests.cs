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
    public class TestRepositoryTests : InMemoryDatabaseCreation
    {
        private readonly IMapper _mapper;
        public TestRepositoryTests()
        {
            Setup();
            _mapper = BasicClassForMocking.ConfigMapper(new TestProfile());
        }

        [Fact]
        public async Task TestRepository_GetAllTests_ReturnAllValues()
        {
            using (var context = new ApplicationDbContext(dbContextOptions))
            {
                //arrange
                var testRepository = new TestRepository(context, _mapper);

                //act
                var tests = await testRepository.GetAllTestsDtoAsync();

                //assert
                Assert.NotNull(tests.ToList());
                Assert.Equal(1, tests.ToList().Count);
                Assert.Equal("Check you emotions", tests.Select(b => b.Title).First());

            }
        }

        [Fact]

        public async Task TestRepository_GetTestById_ReturnValueById()
        {
            using (var context = new ApplicationDbContext(dbContextOptions))
            {
                //arrange
                int id = 1;
                var testRepository = new TestRepository(context, _mapper);

                //act
                var test = await testRepository.GetTestByIdDtoAsync(id);

                //assert
                Assert.NotNull(test);
                Assert.Equal("Check you emotions", test.Title);
                Assert.Equal(TypeOfTests.Easy, test.TypeOfTest);
              
            }
        }

        [Fact]
        public async Task TestRepository_GetTestById()
        {
            using (var context = new ApplicationDbContext(dbContextOptions))
            {
                //arrange
                int id = 1;
                var testRepository = new TestRepository(context, _mapper);

                //act
                var test = await testRepository.GetTestByIdDtoAsync(id);

                //assert
                var expected = ExpectedTests.FirstOrDefault(x => x.Id == id);
                Assert.Equal(expected.Id, test.Id);
                Assert.NotNull(test);

            }
        }

        private static IEnumerable<Test> ExpectedTests =>
           new[]
           {
                  new Test {Id=1, Title = "Check you emotions" }
           };
    }
}
