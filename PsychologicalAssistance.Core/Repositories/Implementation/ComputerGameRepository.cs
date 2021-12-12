using AutoMapper;
using PsychologicalAssistance.Core.Data;
using PsychologicalAssistance.Core.Data.DTOs;
using PsychologicalAssistance.Core.Data.Entities;
using PsychologicalAssistance.Core.Repositories.Abstract;
using PsychologicalAssistance.Core.Repositories.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PsychologicalAssistance.Core.Repositories.Implementation
{
    public class ComputerGameRepository : DataRepository<ComputerGame>, IComputerGameRepository
    {
        private readonly IMapper _mapper;

        public ComputerGameRepository(ApplicationDbContext dbContext, IMapper mapper) : base(dbContext)
        {
            _mapper = mapper;
        }

        public async Task<IEnumerable<ComputerGameDto>> GetAllComputerGamesDtoAsync()
        {
            var games = await GetAllItemsAsync();
            if (games == null)
            {
                return null;
            }

            var gamesDto = _mapper.Map<IEnumerable<ComputerGame>, IEnumerable<ComputerGameDto>>(games);
            return gamesDto;
        }

        public async Task<ComputerGameDto> GetComputerGameByIdDtoAsync(int id)
        {
            var game = await GetItemByIdAsync(id);
            if (game == null)
            {
                return null;
            }

            var gameDto = _mapper.Map<ComputerGame, ComputerGameDto>(game);
            return gameDto;
        }
    }
}
