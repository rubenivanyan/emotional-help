using PsychologicalAssistance.Core.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PsychologicalAssistance.Core.Data.Entities
{
    public class User : BaseEntity
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }
        [Required]
        public string MailAddress { get; set; }
        [Required]
        public DateTime BirthDate { get; set; }
        public Roles Role { get; set; }
        
        public List<TestResults> TestResults { get; set; }
    }
}
