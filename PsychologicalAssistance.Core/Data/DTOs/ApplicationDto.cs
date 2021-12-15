namespace PsychologicalAssistance.Core.Data.DTOs
{
    public class ApplicationDto : BaseDto
    {
        public bool IsArchived { get; set; }
        public string Message { get; set; }
        public int TestResultsId { get; set; }
    }
}
