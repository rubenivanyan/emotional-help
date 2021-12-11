using AutoMapper;
using PsychologicalAssistance.Core.Data;
using PsychologicalAssistance.Core.Data.DTOs;
using PsychologicalAssistance.Core.Data.Entities;
using PsychologicalAssistance.Core.Data.Helpers.AutoMapper;
using PsychologicalAssistance.Core.Repositories.Abstract;
using PsychologicalAssistance.Core.Repositories.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PsychologicalAssistance.Core.Repositories.Implementation
{
    public class QuestionRepository : DataRepository<Question>, IQuestionRepository
    {
        private readonly IMapper _mapper;

        public QuestionRepository(ApplicationDbContext dbContext, IMapper mapper) : base(dbContext)
        {
            _mapper = mapper;
        }

        public async Task<IEnumerable<QuestionDto>> GetAllQuestionsDtoAsync()
        {
            var questions = await GetAllItemsAsync();
            if (questions == null)
            {
                return null;
            }

            var questionsDto = MapCollections.MapCollection<Question, QuestionDto>(questions, _mapper);
            return questionsDto;
        }

        public async Task<QuestionDto> GetQuestionByIdDtoAsync(int id)
        {
            var question = await GetItemByIdAsync(id);
            if (question == null)
            {
                return null;
            }

            var questionDto = _mapper.Map<Question, QuestionDto>(question);
            return questionDto;
        }
    }
}
