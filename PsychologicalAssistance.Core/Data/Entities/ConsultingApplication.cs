using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace PsychologicalAssistance.Core.Data.Entities
{
    public class ConsultingApplication : BaseEntity
    {
        public DateTime ConvenientDay { get; set; }

        [ForeignKey("User")]
        public string UserId { get; set; }
        public User User { get; set; }
        public string UserFullName { get; set; }
        public string Email { get; set; }
    }
}
