using AutoMapper;
using PsychologicalAssistance.Core.Data;
using PsychologicalAssistance.Core.Data.DTOs;
using PsychologicalAssistance.Core.Data.Entities;
using PsychologicalAssistance.Core.Enums;
using PsychologicalAssistance.Core.Repositories.Abstract;
using PsychologicalAssistance.Core.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public async Task<IEnumerable<ComputerGameDto>> GetComputerGamesByGenreDtoAsync(List<string> genres)
        {
            var computerGames = await Task.Run(() => DbSet.AsEnumerable<ComputerGame>()
                .Where(computerGame => genres.Contains(Enum.GetName<ComputerGameGenres>(computerGame.Genre)))
                .Select(computerGame => computerGame).ToList());
            var computerGamesDto = _mapper.Map<IEnumerable<ComputerGame>, IEnumerable<ComputerGameDto>>(computerGames);
            return computerGamesDto;
        }
    }
}
