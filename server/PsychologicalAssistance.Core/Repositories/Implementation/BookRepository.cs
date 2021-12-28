using AutoMapper;
using PsychologicalAssistance.Core.Data;
using PsychologicalAssistance.Core.Data.DTOs;
using PsychologicalAssistance.Core.Data.Entities;
using PsychologicalAssistance.Core.Enums;
using PsychologicalAssistance.Core.Repositories.Abstract;
using PsychologicalAssistance.Core.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PsychologicalAssistance.Core.Repositories.Implementation
{
    public class BookRepository : DataRepository<Book>, IBookRepository
    {
        private readonly IMapper _mapper;

        public BookRepository(ApplicationDbContext dbContext, IMapper mapper) : base(dbContext)
        {
            _mapper = mapper;
        }

        public async Task<IEnumerable<BookDto>> GetAllBooksDtoAsync()
        {
            var books = await GetAllItemsAsync();
            if (books == null)
            {
                return null;
            }

            var booksDto = _mapper.Map<IEnumerable<Book>, IEnumerable<BookDto>>(books);
            return booksDto;
        }

        public async Task<BookDto> GetBookByIdDtoAsync(int id)
        {
            var book = await GetItemByIdAsync(id);
            if (book == null)
            {
                return null;
            }

            var bookDto = _mapper.Map<Book, BookDto>(book);
            return bookDto;
        }

        public async Task<IEnumerable<BookDto>> GetBooksByGenreDtoAsync(List<string> genres)
        {
            var books = await Task.Run(() => DbSet.AsEnumerable<Book>()
                .Where(book => genres.Contains(Enum.GetName<BookGenres>(book.Genre)))
                .Select(book => book).ToList());
            var booksDto = _mapper.Map<IEnumerable<Book>, IEnumerable<BookDto>>(books);
            return booksDto;
        }
    }
}
