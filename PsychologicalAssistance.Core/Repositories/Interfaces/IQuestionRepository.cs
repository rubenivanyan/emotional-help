using PsychologicalAssistance.Core.Data.DTOs;
using PsychologicalAssistance.Core.Data.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PsychologicalAssistance.Core.Repositories.Interfaces
{
    public interface IQuestionRepository : IDataRepository<Question>
    {
        Task<IEnumerable<QuestionDto>> GetAllQuestionsDtoAsync();
        Task<QuestionDto> GetQuestionByIdDtoAsync(int id);
        Task<IEnumerable<FullQuestionDto>> GetAllQuestionsAndVariantsDtoAsync();
        Task<FullQuestionDto> GetQuestionAndVariantsByIdDtoAsync(int id);
    }
}
