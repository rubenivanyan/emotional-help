using PsychologicalAssistance.Core.Data.DTOs;
using PsychologicalAssistance.Core.Data.Entities;
using PsychologicalAssistance.Core.Repositories.Interfaces;
using PsychologicalAssistance.Services.Abstract;
using PsychologicalAssistance.Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PsychologicalAssistance.Services.Implementation
{
    public class BookService : BaseService<Book>, IBookService
    {
        private readonly IBookRepository _bookRepository;

        public BookService(IDataRepository<Book> dataRepository, IUnitOfWork unitOfWork, IBookRepository bookRepository)
            : base(dataRepository, unitOfWork)
        {
            _bookRepository = bookRepository;
        }

        public async Task<IEnumerable<BookDto>> GetAllBooksAsync()
            => await _bookRepository.GetAllBooksDtoAsync();

        public async Task<BookDto> GetBookByIdAsync(int id)
            => await _bookRepository.GetBookByIdDtoAsync(id);
    }
}
