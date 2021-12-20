using PsychologicalAssistance.Core.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace PsychologicalAssistance.Core.Data.Entities
{
    public class QuestionGroupsValues : BaseEntity
    {
        public QuestionGroups QuestionGroup { get; set; }
        public int Value { get; set; }

        [ForeignKey("TestResults")]
        public int TestResultsId { get; set; }
        public TestResults TestResults { get; set; }
    }
}
