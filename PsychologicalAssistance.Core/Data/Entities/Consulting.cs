using System;
using System.Collections.Generic;

namespace PsychologicalAssistance.Core.Data.Entities
{
    public class Consulting : BaseEntity
    {
        public DateTime ConvenientDay { get; set; }

        public ICollection<User> User { get; set; }

        public Consulting()
        {
            User = new List<User>();
        }
    }
}
