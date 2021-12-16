using System;

namespace PsychologicalAssistance.Core.Data.DTOs
{
    public class TrainingDto : BaseDto
    {
        public string Title { get; set; }
        public DateTime StartDate { get; set; }
        public string Description { get; set; }
    }
}
