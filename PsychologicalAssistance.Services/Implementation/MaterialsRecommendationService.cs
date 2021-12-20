using PsychologicalAssistance.Core.Data.DTOs;
using PsychologicalAssistance.Core.Data.Entities;
using PsychologicalAssistance.Core.Repositories.Interfaces;
using PsychologicalAssistance.Services.Helpers;
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
        private readonly IVariantRepository _variantRepository;

        public MaterialsRecommendationService(IFilmRepository filmRepository, IBookRepository bookRepository,
            IMusicRepository musicRepository, IComputerGameRepository computerGameRepository,
            ITestResultsRepository testResultsRepository, IVariantRepository variantRepository)
        {
            _filmRepository = filmRepository;
            _musicRepository = musicRepository;
            _bookRepository = bookRepository;
            _computerGamesRepository = computerGameRepository;
            _testResultsRepository = testResultsRepository;
            _variantRepository = variantRepository;
        }

        public async Task<MaterialsRecommendationsDto> GetMaterialsRecommendationsForUserAsync(User user, int testResultsId)
        {
            var userId = user.Id;
            var answers = await _testResultsRepository.GetAnswersByUserIdAsync(testResultsId, userId);
            var basicEmotion = TestResultsCounting.FindBasicEmotion<AnswerDto>(answers);
            var recommendations = await TestResultsCounting
                .CreateMaterialsRecommendationDto(_filmRepository, _bookRepository, _musicRepository, _computerGamesRepository, _variantRepository, basicEmotion);
            return recommendations;
        }

        public async Task<MaterialsRecommendationsDto> GetMaterialsRecommendationsForGuestAsync(List<VariantDto> chosenVariants)
        {
            var basicEmotion = TestResultsCounting.FindBasicEmotion<VariantDto>(chosenVariants);
            var recommendations = await TestResultsCounting
                .CreateMaterialsRecommendationDto(_filmRepository, _bookRepository, _musicRepository, _computerGamesRepository, _variantRepository, basicEmotion);
            return recommendations;
        }
    }
}
