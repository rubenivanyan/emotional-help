using System.ComponentModel.DataAnnotations.Schema;

namespace PsychologicalAssistance.Core.Data.Entities
{
    public class Answer : BaseQuestion
    {
        [ForeignKey("Question")]
        public int QuestionId { get; set; }
        public Question Question { get; set; }

        [ForeignKey("TestResults")]
        public int TestResultsId { get; set; }
        public TestResults TestResults { get; set; }
    }
}
