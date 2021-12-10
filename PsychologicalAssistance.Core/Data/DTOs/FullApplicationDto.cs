using System;
using System.Collections.Generic;

namespace PsychologicalAssistance.Core.Data.DTOs
{
    public class FullApplicationDto : BaseDto
    {
        public string FullName { get; set; }
        public string MailAddress { get; set; }
        public string TestTitle { get; set; }
        public DateTime Date { get; set; }
        public Dictionary<string, string> QuestionsAndAnswers { get; set; }
        public bool IsArchived { get; set; }
    }
}
