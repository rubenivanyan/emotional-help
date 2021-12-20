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
    public class MusicRepositoryTests : InMemoryDatabaseCreation
    {
        private readonly IMapper _mapper;

        public MusicRepositoryTests()
        {
            Setup();
            _mapper = BasicClassForMocking.ConfigMapper(new MusicProfile());
        }

        [Fact]
        public async Task MusicRepository_GetAllMusics_ReturnAllValues()
        {
            using (var context = new ApplicationDbContext(dbContextOptions))
            {
                //arrange
                var musicRepository = new MusicRepository(context, _mapper);

                //act
                var musics = await musicRepository.GetAllMusicsDtoAsync();

                //assert
                Assert.NotNull(musics.ToList());
                Assert.Equal(4, musics.ToList().Count);
                Assert.Equal("Beyond the sea", musics.Select(b => b.Title).First());
                Assert.Equal("Bobby Darin", musics.Select(b => b.Executor).First());
            }
        }

        [Fact]
        public async Task MusicRepository_GetMusicById_ReturnValueById()
        {
            using (var context = new ApplicationDbContext(dbContextOptions))
            {
                //arrange
                int id = 1;
                var musicRepository = new MusicRepository(context, _mapper);

                //act
                var music = await musicRepository.GetMusicByIdDtoAsync(id);

                //assert
                Assert.NotNull(music);
                Assert.Equal("A Jolly Christmas from Frank Sinatra", music.Title);
                Assert.Equal("Jazz", music.Genre);
                Assert.Equal("EN", music.Language);
            }
        }

        [Fact]
        public async Task MusicRepository_GetMusicById()
        {
            using (var context = new ApplicationDbContext(dbContextOptions))
            {
                //arrange
                int id = 1;
                var musicRepository = new MusicRepository(context, _mapper);

                //act
                var music = await musicRepository.GetMusicByIdDtoAsync(id);

                //assert
                var expected = ExpectedMusics.FirstOrDefault(x => x.Id == id);
                Assert.Equal(expected.Id, music.Id);
                Assert.NotNull(music);
            }
        }

        private static IEnumerable<Music> ExpectedMusics =>
           new[]
           {
                new Music {Id = 1, Title = "A Jolly Christmas from Frank Sinatra", Executor = "Frank Sinatra", Genre = MusicGenres.Jazz, Language = "EN"},
                new Music {Id = 2, Title = "Piano Concerto No. 24", Executor = "Wolfgang Amadeus Mozart", Genre = MusicGenres.Classical, Language = "DN"}
           };
    }
}
