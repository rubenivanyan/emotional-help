using System.ComponentModel.DataAnnotations;

namespace PsychologicalAssistance.Core.Data.DTOs
{
    public class QuestionDto : BaseDto
    {
        [Required]
        public string Formulation { get; set; }
        public string ImageUrl { get; set; }        
    }
}
