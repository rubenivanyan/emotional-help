using PsychologicalAssistance.Core.Enums;

namespace PsychologicalAssistance.Core.Data.DTOs
{
    public class MusicDto : MaterialsDto<MusicGenres>
    {
        public string Executor { get; set; }       
    }
}
