using PsychologicalAssistance.Core.Data.DTOs;
using PsychologicalAssistance.Core.Data.Entities;
using PsychologicalAssistance.Core.Repositories.Interfaces;
using PsychologicalAssistance.Services.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PsychologicalAssistance.Services.Implementation
{
    public class MaterialsRecommendationService : IMaterialsRecommendationService
    {
        private readonly IFilmRepository _filmRepository;
        private readonly IBookRepository _bookRepository;
        private readonly IMusicRepository _musicRepository;
        private readonly IComputerGameRepository _computerGamesRepository;
        private readonly ITestResultsRepository _testResultsRepository;
        private readonly IEmotionGenreRepository _emotionGenreRepository;

        public MaterialsRecommendationService(IFilmRepository filmRepository, IBookRepository bookRepository,
            IMusicRepository musicRepository, IComputerGameRepository computerGameRepository,
            ITestResultsRepository testResultsRepository, IEmotionGenreRepository emotionGenreRepository)
        {
            _filmRepository = filmRepository;
            _musicRepository = musicRepository;
            _bookRepository = bookRepository;
            _computerGamesRepository = computerGameRepository;
            _testResultsRepository = testResultsRepository;
            _emotionGenreRepository = emotionGenreRepository;
        }

        public async Task<MaterialsRecommendationsDto> GetMaterialsRecommendationsForUserAsync(User user, int testResultsId)
        {
            var userId = user.Id;
            var answers = await _testResultsRepository.GetAnswersByUserIdAsync(testResultsId, userId);
            var countEmotions = new Dictionary<string, int>();
            for (int i = 0; i < answers.Count; i++)
            {
                AnswerDto answer = answers[i];
                if (!countEmotions.ContainsKey(answer.Formulation))
                {
                    countEmotions.Add(answer.Formulation, 1);
                }
                else if (countEmotions.ContainsKey(answer.Formulation))
                {
                    countEmotions[answer.Formulation]++;
                }
            }

            var basicEmotion = countEmotions.Aggregate((l, r) => l.Value > r.Value ? l : r).Key;
            var genres = await _emotionGenreRepository.GetGenreByEmotionAsync(basicEmotion);
            var films = await _filmRepository.GetFilmsByGenreDtoAsync(genres);
            var music = await _musicRepository.GetMusicByGenreDtoAsync(genres);
            var books = await _bookRepository.GetBooksByGenreDtoAsync(genres);
            var computerGames = await _computerGamesRepository.GetComputerGamesByGenreDtoAsync(genres);

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
