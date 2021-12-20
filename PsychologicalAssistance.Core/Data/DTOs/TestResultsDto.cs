using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PsychologicalAssistance.Core.Data.DTOs
{
    public class TestResultsDto : BaseDto
    {
        [Required]
        public int TestId { get; set; }
        
        [Required]
        public List<VariantDto> ChosenVariants { get; set; }
        public List<QuestionGroupAndFormulation> Questions { get; set; }
    }
}
