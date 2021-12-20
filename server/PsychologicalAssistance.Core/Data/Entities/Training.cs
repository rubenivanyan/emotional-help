using System;

namespace PsychologicalAssistance.Core.Data.Entities
{
    public class Training : BaseEntity
    {
        public string Title { get; set; }
        public DateTime StartDate { get; set; }
        public string Description { get; set; }
    }
}
