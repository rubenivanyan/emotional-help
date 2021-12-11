using System.Collections.Generic;

namespace PsychologicalAssistance.Core.Data.Entities
{
    public class Variant : BaseQuestion
    {
        public ICollection<Question> Questions { get; set; }
    }
}
