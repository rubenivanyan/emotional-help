namespace PsychologicalAssistance.Core.Data.DTOs
{
    public class TestingApplicationDto : BaseDto
    {
        public bool IsArchived { get; set; }
        public int TestResultsId { get; set; }
    }
}
