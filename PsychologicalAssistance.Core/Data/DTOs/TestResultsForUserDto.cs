using System;
using System.Collections.Generic;

namespace PsychologicalAssistance.Core.Data.DTOs
{
    public class TestResultsForUserDto : BaseDto
    {
        public string ResultsDate { get; set; }
        public string UserId { get; set; }
        public string UserFullName { get; set; }
        public int TestId { get; set; }
        public List<QuestionDto> Questions { get; set; }
        public List<AnswerDto> Answers { get; set; }
    }
}
