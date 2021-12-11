using PsychologicalAssistance.Core.Enums;

namespace PsychologicalAssistance.Core.Data.Entities
{
    public class Music : Materials<MusicGenres>
    {
        public string Executor { get; set; }
    }
}
