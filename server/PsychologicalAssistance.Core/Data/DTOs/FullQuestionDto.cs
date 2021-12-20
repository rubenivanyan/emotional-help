using System.Collections.Generic;

namespace PsychologicalAssistance.Core.Data.DTOs
{
    public class FullQuestionDto : QuestionDto
    {
        public List<VariantDto> Variants { get; set; }
    }
}