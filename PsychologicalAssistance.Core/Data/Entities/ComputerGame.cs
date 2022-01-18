using PsychologicalAssistance.Core.Enums;

namespace PsychologicalAssistance.Core.Data.Entities
{
    public class ComputerGame : Materials<ComputerGameGenres>
    {
        public string Company { get; set; }
        public string Review { get; set; }
    }
}
