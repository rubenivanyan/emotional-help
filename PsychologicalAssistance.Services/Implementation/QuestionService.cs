using PsychologicalAssistance.Core.Data.DTOs;
using PsychologicalAssistance.Core.Data.Entities;
using PsychologicalAssistance.Core.Repositories.Interfaces;
using PsychologicalAssistance.Services.Abstract;
using PsychologicalAssistance.Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PsychologicalAssistance.Services.Implementation
{
    public class QuestionService : BaseService<Question>, IQuestionService
    {
        private readonly IQuestionRepository _questionRepository;
        private readonly ITestRepository _testRepository;

        public QuestionService(IDataRepository<Question> dataRepository, IUnitOfWork unitOfWork, IQuestionRepository questionRepository, ITestRepository testRepository)
            : base(dataRepository, unitOfWork)
        {
            _questionRepository = questionRepository;
            _testRepository = testRepository;
        }

        public async Task<IEnumerable<QuestionDto>> GetAllQuestionsAsync()
            => await _questionRepository.GetAllQuestionsDtoAsync();

        public async Task<QuestionDto> GetQuestionByIdAsync(int id)
            => await _questionRepository.GetQuestionByIdDtoAsync(id);

        public async Task<IEnumerable<FullQuestionDto>> GetAllQuestionsAndVariants()
            => await _questionRepository.GetAllQuestionsAndVariantsDtoAsync();

        public async Task<FullQuestionDto> GetQuestionAndVariantsByIdAsync(int id)
            => await _questionRepository.GetQuestionAndVariantsByIdDtoAsync(id);

        public async Task AddQuestionToTest(int questionId, int testId)
        {
            var question = await _questionRepository.GetItemByIdAsync(questionId);
            var test = await _testRepository.GetItemByIdAsync(testId);
            question.Tests.Add(test);
            await _questionRepository.UpdateAsync(question);
            await _unitOfWork.CommitAsync();
        }
    }
}
