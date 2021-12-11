using PsychologicalAssistance.Core.Data.DTOs;
using PsychologicalAssistance.Core.Data.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PsychologicalAssistance.Core.Repositories.Interfaces
{
    public interface IBookRepository : IDataRepository<Book>
    {
        Task<IEnumerable<BookDto>> GetAllBooksDtoAsync();
        Task<BookDto> GetBookByIdDtoAsync(int id);
    }
}
