using PsychologicalAssistance.Core.Enums;

namespace PsychologicalAssistance.Core.Data.DTOs
{
    public class ComputerGameDto : MaterialsDto<ComputerGameGenres>
    {
        public string Company { get; set; }
        public string Review { get; set; }
    }
}
