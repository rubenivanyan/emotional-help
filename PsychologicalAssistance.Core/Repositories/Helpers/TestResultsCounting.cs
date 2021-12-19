using PsychologicalAssistance.Core.Data.DTOs;
using PsychologicalAssistance.Core.Data.Entities;
using PsychologicalAssistance.Core.Enums;
using System;
using System.Collections.Generic;

namespace PsychologicalAssistance.Core.Repositories.Helpers
{
    public static class TestResultsCounting
    {
        public static List<QuestionGroupsValues> CountQuestionGroupsValues(TestResultsDto testResultsDto)
        {
            var questionGroupsValues = new List<QuestionGroupsValues>();
            questionGroupsValues.Add(new QuestionGroupsValues
            {
                QuestionGroup = Enum.Parse<QuestionGroups>(testResultsDto.Questions[0].QuestionGroup),
                Value = testResultsDto.ChosenVariants[0].Value
            });

            for (int i = 1; i < testResultsDto.ChosenVariants.Count; i++)
            {
                var group = Enum.Parse<QuestionGroups>(testResultsDto.Questions[i].QuestionGroup);
                var isGroupAdded = false;
                for (int j = 0; j < questionGroupsValues.Count; j++)
                {
                    if (questionGroupsValues[j].QuestionGroup == group)
                    {
                        questionGroupsValues[j].Value += testResultsDto.ChosenVariants[i].Value;
                        isGroupAdded = true;
                    }
                }

                if (!isGroupAdded)
                {
                    questionGroupsValues.Add(new QuestionGroupsValues
                    {
                        QuestionGroup = group,
                        Value = testResultsDto.ChosenVariants[i].Value
                    });
                }
            }

            return questionGroupsValues;
        }
    }
}
