using PsychologicalAssistance.Core.Enums;

namespace PsychologicalAssistance.Core.Data.DTOs
{
    public class BaseTestDto : BaseDto
    {
        public string Title { get; set; }
        public TypeOfTests TypeOfTest { get; set; }
    }
}
