using PsychologicalAssistance.Core.Data.DTOs;
using PsychologicalAssistance.Core.Data.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PsychologicalAssistance.Core.Repositories.Interfaces
{
    public interface IQuestionRepository : IDataRepository<Question>
    {
        public Task<IEnumerable<QuestionDto>> GetAllQuestionsDtoAsync();
        public Task<QuestionDto> GetQuestionByIdDtoAsync(int id);
    }
}
