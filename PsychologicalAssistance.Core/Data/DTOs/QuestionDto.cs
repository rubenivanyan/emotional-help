using System.ComponentModel.DataAnnotations;

namespace PsychologicalAssistance.Core.Data.DTOs
{
    public class QuestionDto : BaseQuestionDto
    {
        public string ImageUrl { get; set; }        
    }
}
