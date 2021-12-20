using PsychologicalAssistance.Core.Data.DTOs;
using PsychologicalAssistance.Core.Data.Entities;
using PsychologicalAssistance.Core.Enums;
using PsychologicalAssistance.Core.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PsychologicalAssistance.Services.Helpers
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

        public static string FindBasicEmotion<TDto>(List<TDto> chosenVariants) where TDto : BaseQuestionDto
        {
            var countEmotions = new Dictionary<string, int>();
            for (int i = 0; i < chosenVariants.Count; i++)
            {
                TDto chosenVariant = chosenVariants[i];
                if (!countEmotions.ContainsKey(chosenVariant.Formulation))
                {
                    countEmotions.Add(chosenVariant.Formulation, 1);
                }
                else if (countEmotions.ContainsKey(chosenVariant.Formulation))
                {
                    countEmotions[chosenVariant.Formulation]++;
                }
            }

            var basicEmotion = countEmotions.Aggregate((l, r) => l.Value > r.Value ? l : r).Key;
            return basicEmotion;
        }

        public static async Task<MaterialsRecommendationsDto> CreateMaterialsRecommendationDto(IFilmRepository filmRepository, IBookRepository bookRepository,
            IMusicRepository musicRepository, IComputerGameRepository computerGameRepository, IVariantRepository variantRepository, string basicEmotion)
        {
            var genresTitles = await variantRepository.GetGenresTitlesByVariantTitleAsync(basicEmotion);
            var films = await filmRepository.GetFilmsByGenreDtoAsync(genresTitles);
            var music = await musicRepository.GetMusicByGenreDtoAsync(genresTitles);
            var books = await bookRepository.GetBooksByGenreDtoAsync(genresTitles);
            var computerGames = await computerGameRepository.GetComputerGamesByGenreDtoAsync(genresTitles);

            var recommendations = new MaterialsRecommendationsDto
            {
                Films = films.ToList(),
                Books = books.ToList(),
                Music = music.ToList(),
                ComputerGames = computerGames.ToList()
            };

            return recommendations;
        }
    }
}
