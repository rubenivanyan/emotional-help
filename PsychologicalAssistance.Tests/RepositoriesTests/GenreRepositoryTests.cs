using AutoMapper;
using PsychologicalAssistance.Core.Data;
using PsychologicalAssistance.Core.Data.Entities;
using PsychologicalAssistance.Core.Data.Helpers.AutoMapper;
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
                var genreRepository = new GenreRepository(context, _mapper);

                //act
                var genres = await genreRepository.GetAllGenresDtoAsync();

                //assert
                Assert.NotNull(genres.ToList());
                Assert.Equal(25, genres.ToList().Count);
                Assert.Equal("JuvenileFantasy", genres.Select(b => b.Title).FirstOrDefault());
            }
        }

        [Fact]
        public async Task GenreRepository_GetGenreById_ReturnValueById()
        {
            using (var context = new ApplicationDbContext(dbContextOptions))
            {
                //arrange
                int id = 2;
                var genreRepository = new GenreRepository(context, _mapper);

                //act
                var genre = await genreRepository.GetGenreByIdDtoAsync(id);

                //assert
                Assert.NotNull(genre);
                Assert.Equal("Fantasy", genre.Title);
            }
        }

        [Fact]
        public async Task GenreRepository_GetGenreById()
        {
            using (var context = new ApplicationDbContext(dbContextOptions))
            {
                //arrange
                int id = 1;
                var genreRepository = new GenreRepository(context, _mapper);

                //act
                var genre = await genreRepository.GetGenreByIdDtoAsync(id);

                //assert
                var expected = ExpectedGenres.FirstOrDefault(x => x.Id == id);
                Assert.Equal(expected.Id, genre.Id);
                Assert.NotNull(genre);
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
