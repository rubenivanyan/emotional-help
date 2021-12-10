using PsychologicalAssistance.Core.Data.DTOs;
using PsychologicalAssistance.Core.Data.Enitities;
using PsychologicalAssistance.Core.Repositories.Interfaces;
using PsychologicalAssistance.Services.Abstract;
using PsychologicalAssistance.Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PsychologicalAssistance.Services.Implementation
{
    public class UserService : BaseService<User>, IUserService
    {
        private readonly IUserRepository _userRepository;
        
        public UserService(IDataRepository<User> dataRepository, IUserRepository userRepository, IUnitOfWork unitOfWork) : base(dataRepository, unitOfWork) 
        {
            _userRepository = userRepository;
        }

        public async Task<IEnumerable<UserDto>> GetAllUsersAsync()
            => await _userRepository.GetAllUsersDtoAsync();

        public async Task<UserDto> GetUserByIdAsync(int id)
            => await _userRepository.GetUserByIdDtoAsync(id);
    }
}
