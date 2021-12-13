using PsychologicalAssistance.Core.Enums;
using System.Collections.Generic;

namespace PsychologicalAssistance.Core.Data.Entities
{
    public class Test:BaseEntity
    {
        public string Title { get; set; }
        public TypeOfTests TypeOfTest { get; set; }
        public virtual ICollection<Question> Questions { get; set; }
        public Test()
        {
            Questions = new List<Question>();
        }
   }
}
