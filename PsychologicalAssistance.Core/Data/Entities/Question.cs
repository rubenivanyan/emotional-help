using PsychologicalAssistance.Core.Enums;
using System.Collections.Generic;

namespace PsychologicalAssistance.Core.Data.Entities
{
    public class Question : BaseQuestion
    {
        public string ImageUrl { get; set; }
        public QuestionGroups QuestionGroup { get; set; }
        
        public ICollection<Variant> Variants { get; set; }
        public ICollection<Test> Tests { get; set; }
        public Question()
        {
            Variants = new List<Variant>();
            Tests = new List<Test>();
        }
    }
}
