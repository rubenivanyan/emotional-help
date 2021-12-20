using PsychologicalAssistance.Core.Data.DTOs;
using PsychologicalAssistance.Core.Data.Entities;
using PsychologicalAssistance.Core.Repositories.Interfaces;
using PsychologicalAssistance.Services.Abstract;
using PsychologicalAssistance.Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PsychologicalAssistance.Services.Implementation
{
    public class ComputerGameService : BaseService<ComputerGame>, IComputerGameService
    {
        private readonly IComputerGameRepository _computerGameRepository;

        public ComputerGameService(IDataRepository<ComputerGame> dataRepository, IUnitOfWork unitOfWork, IComputerGameRepository computerGameRepository)
            : base(dataRepository, unitOfWork)
        {
            _computerGameRepository = computerGameRepository;
        }

        public async Task<IEnumerable<ComputerGameDto>> GetAllComputerGamesAsync()
            => await _computerGameRepository.GetAllComputerGamesDtoAsync();

        public async Task<ComputerGameDto> GetComputerGameByIdAsync(int id)
            => await _computerGameRepository.GetComputerGameByIdDtoAsync(id);
    }
}
