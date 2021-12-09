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
        public UserService(IDataRepository<User> dataRepository) : base(dataRepository) { }

        //If this idea is correct, I'll create AutoMapper
        private User DtoToUser(UserDto userDto)
        {
            var user = new User
            {
                Name = userDto.Name,
                Surname = userDto.Surname,
                BirthDate = userDto.BirthDate,
                Role = userDto.Role
            };

            return user;
        }

        private UserDto UserToDto(User user)
        {
            var userDto = new UserDto
            {
                Id = user.Id,
                Name = user.Name,
                Surname = user.Surname,
                BirthDate = user.BirthDate,
                Role = user.Role
            };

            return userDto;
        }

        public async Task CreateUserAsync(UserDto userDto)
        {
            var user = DtoToUser(userDto);
            await CreateAsync(user);
        }

        public async Task DeleteUserAsync(int id)
            => await DeleteAsync(id);

        public async Task<IEnumerable<UserDto>> GetAllUsersAsync()
        {
            var users = await GetAllItemsAsync();
            var usersDtos = new List<UserDto>();
            foreach(var user in users)
            {
                usersDtos.Add(UserToDto(user));
            }

            return usersDtos;
        }

        public async Task<UserDto> GetUserByIdAsync(int id)
        {
            var user = await GetItemByIdAsync(id);
            var userDto = UserToDto(user);
            return userDto;
        }

        public async Task UpdateUserAsync(UserDto userDto)
        {
            var user = DtoToUser(userDto);
            user.Id = userDto.Id;
            await UpdateAsync(user);
        }
    }
}
