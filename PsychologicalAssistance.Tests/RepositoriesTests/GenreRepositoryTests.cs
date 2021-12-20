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
    public class GenreRepositoryTests : InMemoryDatabaseCreation
    {
        private readonly IMapper _mapper;
        public GenreRepositoryTests()
        {
            Setup();
            _mapper = BasicClassForMocking.ConfigMapper(new GenreProfile());
        }

        [Fact]
        public async Task GenreRepository_GetAllGenres_ReturnAllValues()
        {
            using (var context = new ApplicationDbContext(dbContextOptions))
            {
                //arrange
                var GenreRepository = new GenreRepository(context, _mapper);

                //act
                var Genres = await GenreRepository.GetAllGenresDtoAsync();

                //assert
                Assert.NotNull(Genres.ToList());
                Assert.Equal(25, Genres.ToList().Count);
                Assert.Equal("JuvenileFantasy", Genres.Select(b => b.Title).FirstOrDefault());

            }
        }

        [Fact]

        public async Task GenreRepository_GetGenreById_ReturnValueById()
        {
            using (var context = new ApplicationDbContext(dbContextOptions))
            {
                //arrange
                int id = 2;
                var GenreRepository = new GenreRepository(context, _mapper);

                //act
                var Genre = await GenreRepository.GetGenreByIdDtoAsync(id);

                //assert
                Assert.NotNull(Genre);
                Assert.Equal("Fantasy", Genre.Title);
             
            }
        }

        [Fact]
        public async Task GenreRepository_GetGenreById()
        {
            using (var context = new ApplicationDbContext(dbContextOptions))
            {
                //arrange
                int id = 1;
                var GenreRepository = new GenreRepository(context, _mapper);

                //act
                var Genre = await GenreRepository.GetGenreByIdDtoAsync(id);

                //assert
                var expected = ExpectedGenres.FirstOrDefault(x => x.Id == id);
                Assert.Equal(expected.Id, Genre.Id);
                Assert.NotNull(Genre);

            }
        }

        private static IEnumerable<Genre> ExpectedGenres =>
           new[]
           {
                new Genre { Id = 1,  Title = "Detective"},
                new Genre { Id = 2,  Title = "Fantasy" }
           };
    }
}
