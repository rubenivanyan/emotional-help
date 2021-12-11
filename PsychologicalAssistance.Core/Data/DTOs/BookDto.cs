using PsychologicalAssistance.Core.Enums;

namespace PsychologicalAssistance.Core.Data.DTOs
{
    public class BookDto : MaterialsDto<BookGenres>
    {
        public string Author { get; set; }
    }
}
