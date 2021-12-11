using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace PsychologicalAssistance.Core.Data.Entities
{
    public class TestResults : BaseEntity
    {
        public DateTime ResultsDate { get; set; }
        
        [ForeignKey("Test")]
        public int TestId { get; set; }
        public Test Test { get; set; }
       
        [ForeignKey("User")]
        public int UserId { get; set; }
        public User User { get; set; }

        public List<Answer> Answers { get; set; }
    }
}
