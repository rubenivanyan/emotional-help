using System.Collections.Generic;

namespace PsychologicalAssistance.Core.Data.Entities
{
    public class Question : BaseQuestion
    {
        public string ImageUrl { get; set; }
        
        public ICollection<Variant> Variants { get; set; }
        public Question()
        {
            Variants = new List<Variant>();
        }
    }
}
