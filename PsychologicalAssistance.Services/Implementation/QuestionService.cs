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

        public QuestionService(IDataRepository<Question> dataRepository, IUnitOfWork unitOfWork, IQuestionRepository questionRepository)
            : base(dataRepository, unitOfWork)
        {
            _questionRepository = questionRepository;
        }

        public async Task<IEnumerable<QuestionDto>> GetAllQuestionsAsync()
            => await _questionRepository.GetAllQuestionsDtoAsync();

        public async Task<QuestionDto> GetQuestionByIdAsync(int id)
            => await _questionRepository.GetQuestionByIdDtoAsync(id);
    }
}
