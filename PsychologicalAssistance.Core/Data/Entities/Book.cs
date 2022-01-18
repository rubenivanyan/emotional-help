using PsychologicalAssistance.Core.Enums;

namespace PsychologicalAssistance.Core.Data.Entities
{
    public class Book : Materials<BookGenres>
    {
        public string Author { get; set; }
    }
}
