using System;
using System.Collections.Generic;

namespace PsychologicalAssistance.Core.Data.DTOs
{
    public class FullApplicationDto : ApplicationDto
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Message { get; set; }
        public List<string> QuestionsFormulations { get; set; }
        public List<string> AnswersFormulations { get; set; }
        public DateTime DateOfResults { get; set; }
    }
}
