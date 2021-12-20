using PsychologicalAssistance.Core.Data.DTOs;
using PsychologicalAssistance.Core.Data.Entities;
using PsychologicalAssistance.Core.Repositories.Interfaces;
using PsychologicalAssistance.Services.Abstract;
using PsychologicalAssistance.Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PsychologicalAssistance.Services.Implementation
{
    public class GenreService : BaseService<Genre>, IGenreService
    {
        private readonly IGenreRepository _genreRepository;
        private readonly IVariantRepository _variantRepository;

        public GenreService(IDataRepository<Genre> dataRepository, IUnitOfWork unitOfWork,
            IGenreRepository genreRepository, IVariantRepository variantRepository)
            : base (dataRepository, unitOfWork)
        {
            _genreRepository = genreRepository;
            _variantRepository = variantRepository;
        }

        public async Task AddGenreToVariant(int variantId, int genreId)
        {
            var variant = await _variantRepository.GetItemByIdAsync(variantId);
            var genre = await _genreRepository.GetItemByIdAsync(genreId);
            variant.Genres.Add(genre);
            await _variantRepository.UpdateAsync(variant);
            await _unitOfWork.CommitAsync();
        }

        public async Task<IEnumerable<GenreDto>> GetAllGenresAsync()
            => await _genreRepository.GetAllGenresDtoAsync();

        public async Task<GenreDto> GetGenreByIdAsync(int id)
            => await _genreRepository.GetGenreByIdDtoAsync(id);
    }
}
