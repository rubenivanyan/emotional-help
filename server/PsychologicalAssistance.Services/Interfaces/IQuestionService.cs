using PsychologicalAssistance.Core.Data.DTOs;
using PsychologicalAssistance.Core.Data.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PsychologicalAssistance.Services.Interfaces
{
    public interface IQuestionService : IBaseService<Question>
    {
        Task<IEnumerable<QuestionDto>> GetAllQuestionsAsync();
        Task<QuestionDto> GetQuestionByIdAsync(int id);
        Task<IEnumerable<FullQuestionDto>> GetAllQuestionsAndVariants();
        Task<FullQuestionDto> GetQuestionAndVariantsByIdAsync(int id);
        Task AddQuestionToTest(int questionId, int testId);
    }
}
