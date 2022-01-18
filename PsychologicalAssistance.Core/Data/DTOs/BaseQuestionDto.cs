using System.ComponentModel.DataAnnotations;

namespace PsychologicalAssistance.Core.Data.DTOs
{
    public abstract class BaseQuestionDto : BaseDto
    {
        [Required]
        public string Formulation { get; set; }
    }
}
