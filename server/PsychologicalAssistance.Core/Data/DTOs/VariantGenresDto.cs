using System.Collections.Generic;

namespace PsychologicalAssistance.Core.Data.DTOs
{
    public class VariantGenresDto : VariantDto
    {
        public List<GenreDto> Genres { get; set; }
    }
}
