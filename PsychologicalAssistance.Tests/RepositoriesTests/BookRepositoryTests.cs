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
    public class BookRepositoryTests : InMemoryDatabaseCreation
    {
        private readonly IMapper _mapper;
        public BookRepositoryTests()
        {
            Setup();
            _mapper = BasicClassForMocking.ConfigMapper(new BookProfile());
        }

        [Fact]
        public async Task BookRepository_GetAllBooks_ReturnAllValues()
        {
            using (var context = new ApplicationDbContext(dbContextOptions))
            {
                //arrange
                var bookRepository = new BookRepository(context, _mapper);

                //act
                var books = await bookRepository.GetAllBooksDtoAsync();

                //assert
                Assert.NotNull(books.ToList());
                Assert.Equal(10, books.ToList().Count);
                Assert.Equal("How Beautiful We Were", books.Select(b => b.Title).First());
                 
            }
        }

        [Fact]

        public async Task BookRepository_GetBookById_ReturnValueById()
        {
            using (var context = new ApplicationDbContext(dbContextOptions))
            {
                //arrange
                int id = 1;
                var bookRepository = new BookRepository(context, _mapper);

                //act
                var book = await bookRepository.GetBookByIdDtoAsync(id);

                //assert
                Assert.NotNull(book);
                Assert.Equal("How Beautiful We Were", book.Title);
                Assert.Equal("Novel", book.Genre);
                Assert.Equal("EN", book.Language);
                Assert.Equal("Imbolo Mbue", book.Author);
            }
        }

        [Fact]
        public async Task BookRepository_GetBookById()
        {
            using (var context = new ApplicationDbContext(dbContextOptions))
            {
                //arrange
                int id = 1;
                var bookRepository = new BookRepository(context, _mapper);

                //act
                var book = await bookRepository.GetBookByIdDtoAsync(id);

                //assert
                var expected = ExpectedBooks.FirstOrDefault(x => x.Id == id);
                Assert.Equal(expected.Id, book.Id);
                Assert.NotNull(book);

            }
        }

        private static IEnumerable<Book> ExpectedBooks =>
           new[]
           {
                new Book { Id = 1,  Title = "How Beautiful We Were" , Author="Imbolo Mbue", Genre = BookGenres.Novel , Language = "EN" } ,
                new Book { Id = 2,  Title = "The Hobbit, or There and Back Again" , Author ="J.R.R. Tolkien", Genre = BookGenres.JuvenileFantasy , Language = "EN" }
           };
    }
}
