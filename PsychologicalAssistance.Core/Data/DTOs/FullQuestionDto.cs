using System.Collections.Generic;

namespace PsychologicalAssistance.Core.Data.DTOs
{
    public class FullQuestionDto : BaseQuestionDto
    {
        public string ImageUrl { get; set; }
        public List<VariantDto> Variants { get; set; }
    }
}