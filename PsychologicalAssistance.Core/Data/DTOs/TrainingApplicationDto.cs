using PsychologicalAssistance.Core.Data.Entities;

namespace PsychologicalAssistance.Core.Data.DTOs
{
    public class TrainingApplicationDto : BaseDto
    {
        public string UserId { get; set; }
        public int TrainingId { get; set; }
    }
}
