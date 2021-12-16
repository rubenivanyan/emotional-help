using System;
using System.Collections.Generic;

namespace PsychologicalAssistance.Core.Data.DTOs
{
    public class FullApplicationDto : ApplicationDto
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public List<string> QuestionsFormulations { get; set; }
        public List<string> AnswersFormulations { get; set; }
        public string DateOfResults { get; set; }
    }
}
