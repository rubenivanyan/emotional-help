using System.Collections.Generic;

namespace PsychologicalAssistance.Core.Data.DTOs
{
    public class TestResultsForGuestWithRecommendationsDto
    {
        public List<string> Questions { get; set; }
        public List<string> Answers { get; set; }
        public List<QuestionGroupsValuesDto> QuestionGroupsValues { get; set; }
        public MaterialsRecommendationsDto MaterialsRecommendations { get; set; }
    }
}
