using AutoMapper;
using PsychologicalAssistance.Core.Data;
using PsychologicalAssistance.Core.Data.Helpers.AutoMapper;
using PsychologicalAssistance.Core.Repositories.Implementation;
using PsychologicalAssistance.Tests.Common;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace PsychologicalAssistance.Tests.RepositoriesTests
{
    public class VariantRepositoryTests : InMemoryDatabaseCreation
    {
        private readonly IMapper _mapper;

        public VariantRepositoryTests()
        {
            Setup();
            _mapper = BasicClassForMocking.ConfigMapper(new VariantProfile());
        }

        [Fact]
        public async Task VariantRepository_GetAllVariants_ReturnAllValues()
        {
            using (var context = new ApplicationDbContext(dbContextOptions))
            {
                //arrange
                var variantRepository = new VariantRepository(context, _mapper);

                //act
                var variants = await variantRepository.GetAllVariantsDtoAsync();

                //assert
                Assert.NotNull(variants.ToList());
                Assert.Equal(8, variants.ToList().Count);
                Assert.Equal("indifference", variants.Select(b => b.Formulation).First());
            }
        }
    }
}
