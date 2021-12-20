using System.Collections.Generic;

namespace PsychologicalAssistance.Core.Data.DTOs
{
    public class FullTestDto : BaseTestDto
    {
        public List<FullQuestionDto> Questions { get; set; }
    }
}
