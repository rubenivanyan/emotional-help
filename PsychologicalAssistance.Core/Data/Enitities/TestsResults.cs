using System;

namespace PsychologicalAssistance.Core.Data.Enitities
{
    public class TestResults:BaseEntity
    {
        public DateTime ResultsDate { get; set; }
        
        public int TestId { get; set; } //FK
        public Test Test { get; set; } //Навигационное свойство
       
        public int UserId { get; set; }//FK
        public User User { get; set; } //Навигационное свойство
    }
}
