using AutoMapper;
using PsychologicalAssistance.Core.Data;
using PsychologicalAssistance.Core.Data.Entities;
using PsychologicalAssistance.Core.Data.Helpers.AutoMapper;
using PsychologicalAssistance.Core.Enums;
using PsychologicalAssistance.Core.Repositories.Implementation;
using PsychologicalAssistance.Tests.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;


namespace PsychologicalAssistance.Tests.RepositoriesTests
{
    public class FilmRepositoryTests : InMemoryDatabaseCreation
    {
        private readonly IMapper _mapper;

        public FilmRepositoryTests()
        {
            Setup();
            _mapper = BasicClassForMocking.ConfigMapper(new FilmProfile());
        }

        [Fact]
        public async Task FilmRepository_GetAllFilms_ReturnAllValues()
        {
            using (var context = new ApplicationDbContext(dbContextOptions))
            {
                //arrange
                var filmRepository = new FilmRepository(context, _mapper);

                //act
                var films = await filmRepository.GetAllFilmsDtoAsync();

                //assert
                Assert.NotNull(films.ToList());
                Assert.Equal(4, films.ToList().Count);
                Assert.Equal("Raiders of the Lost Ark", films.Select(b => b.Title).First());
            }
        }

        [Fact]
        public async Task FilmRepository_GetFilmById_ReturnValueById()
        {
            using (var context = new ApplicationDbContext(dbContextOptions))
            {
                //arrange
                int id = 1;
                var filmRepository = new FilmRepository(context, _mapper);

                //act
                var film = await filmRepository.GetFilmByIdDtoAsync(id);

                //assert
                Assert.NotNull(film);
                Assert.Equal("The Godfather", film.Title);
                Assert.Equal("Drama", film.Genre);
                Assert.Equal("EN", film.Language);
                Assert.Equal("1972", film.Year);
            }
        }

        [Fact]
        public async Task FilmRepository_GetFilmById()
        {
            using (var context = new ApplicationDbContext(dbContextOptions))
            {
                //arrange
                int id = 1;
                var filmRepository = new FilmRepository(context, _mapper);

                //act
                var film = await filmRepository.GetFilmByIdDtoAsync(id);

                //assert
                var expected = ExpectedFilms.FirstOrDefault(x => x.Id == id);
                Assert.Equal(expected.Id, film.Id);
                Assert.NotNull(film);
            }
        }

        private static IEnumerable<Film> ExpectedFilms =>
		   new[]
		   {
			   new Film
               {
                   Id=1,
                   Title = "The Godfather",
                   Genre = FilmGenres.Drama,
                   Country = "USA",
                   Year = new DateTime(1972, 1, 1),
                   Language = "EN",
                   VideoUrl = "google.com"
               },
               new Film
               {
                   Id=2,
                   Title = "The Shawshank Redemption",
                   Genre = FilmGenres.Drama,
                   Country = "USA",
                   Year = new DateTime(1994, 1, 1),
                   Language = "EN",
                   VideoUrl = "www.facebook.com"
               }
		   };
    }
}
