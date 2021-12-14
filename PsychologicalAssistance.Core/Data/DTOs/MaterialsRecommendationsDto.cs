using System.Collections.Generic;

namespace PsychologicalAssistance.Core.Data.DTOs
{
    public class MaterialsRecommendationsDto
    {
        public List<FilmDto> Films { get; set; }
        public List<MusicDto> Music { get; set; }
        public List<BookDto> Books { get; set; }
        public List<ComputerGameDto> ComputerGames { get; set; }
    }
}
