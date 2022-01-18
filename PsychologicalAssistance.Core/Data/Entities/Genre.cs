using System.Collections.Generic;

namespace PsychologicalAssistance.Core.Data.Entities
{
    public class Genre : BaseEntity
    {
        public string Title { get; set; }

        public ICollection<Variant> Variants { get; set; }

        public Genre()
        {
            Variants = new List<Variant>();
        }
    }
}
