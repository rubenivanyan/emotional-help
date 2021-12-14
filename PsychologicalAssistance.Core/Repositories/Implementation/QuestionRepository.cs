using AutoMapper;
using Microsoft.EntityFrameworkCore;
using PsychologicalAssistance.Core.Data;
using PsychologicalAssistance.Core.Data.DTOs;
using PsychologicalAssistance.Core.Data.Entities;
using PsychologicalAssistance.Core.Repositories.Abstract;
using PsychologicalAssistance.Core.Repositories.Interfaces;
using System.Collections.Generic;
using System.Linq;
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

            var questionsDto = _mapper.Map<IEnumerable<Question>, IEnumerable<QuestionDto>>(questions);
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

        public async Task<IEnumerable<FullQuestionDto>> GetAllQuestionsAndVariantsDtoAsync()
        {
            var questions = await Task.Run(() => DbSet.Select(question => new FullQuestionDto
            {
                Id = question.Id,
                Formulation = question.Formulation,
                ImageUrl = question.ImageUrl,
                Variants = _mapper.Map<IEnumerable<Variant>, IEnumerable<VariantDto>>(question.Variants).ToList()
            }));

            return questions;
        }

        public async Task<FullQuestionDto> GetQuestionAndVariantsByIdDtoAsync(int id)
        {
            var question = await Task.Run(() => DbSet.Where(question => question.Id == id).Include(v => v.Variants).Select(question => new FullQuestionDto
            {
                Id = question.Id,
                Formulation = question.Formulation,
                ImageUrl = question.ImageUrl,
                Variants = _mapper.Map<IEnumerable<Variant>, IEnumerable<VariantDto>>(question.Variants).ToList()
            }).FirstOrDefaultAsync());
            return question;
        }
    }
}
