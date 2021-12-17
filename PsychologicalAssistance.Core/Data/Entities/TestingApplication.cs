using System.ComponentModel.DataAnnotations.Schema;

namespace PsychologicalAssistance.Core.Data.Entities
{
    public class TestingApplication : BaseEntity
    {
        public bool IsArchived { get; set; } = false;
        public string Message { get; set; }
        [ForeignKey("TestResults")]
        public int TestResultsId { get; set; }
        public TestResults TestResults { get; set; }
    }
}
