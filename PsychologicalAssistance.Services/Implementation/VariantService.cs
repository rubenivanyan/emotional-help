using PsychologicalAssistance.Core.Data.DTOs;
using PsychologicalAssistance.Core.Data.Entities;
using PsychologicalAssistance.Core.Repositories.Interfaces;
using PsychologicalAssistance.Services.Abstract;
using PsychologicalAssistance.Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PsychologicalAssistance.Services.Implementation
{
    public class VariantService : BaseService<Variant>, IVariantService
    {
        private readonly IVariantRepository _variantRepository;
        private readonly IQuestionRepository _questionRepository;

        public VariantService(IDataRepository<Variant> dataRepository, IUnitOfWork unitOfWork, IVariantRepository variantRepository, IQuestionRepository questionRepository)
            : base(dataRepository, unitOfWork)
        {
            _variantRepository = variantRepository;
            _questionRepository = questionRepository;
        }

        public async Task<IEnumerable<VariantDto>> GetAllVariantsDtoAsync()
            => await _variantRepository.GetAllVariantsDtoAsync();

        public async Task<VariantDto> GetVariantByIdDtoAsync(int id)
            => await _variantRepository.GetVariantDtoAsync(id);

        public async Task AddVariantToQuestion(int questionId, int variantId)
        {
            var question = await _questionRepository.GetItemByIdAsync(questionId);
            var variant = await _variantRepository.GetItemByIdAsync(variantId);
            question.Variants.Add(variant);
            await _questionRepository.UpdateAsync(question);
            await _unitOfWork.CommitAsync();
        }
    }
}