using AutoMapper;
using PsychologicalAssistance.Core.Data.DTOs;
using PsychologicalAssistance.Core.Data.Enitities;
using PsychologicalAssistance.Core.Repositories.Interfaces;
using PsychologicalAssistance.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PsychologicalAssistance.Services.Implementation
{
    public class UserService : IUserService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public UserService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }

        public async Task<IEnumerable<UserDto>> GetAllUsersAsync()
        {
            var result = await unitOfWork.UserRepository.GetAllUsersAsync();
            return mapper.Map<IEnumerable<UserDto>>(result);
        }

        public async Task<UserDto> GetUserByIdAsync(int id)
        {
            var result = await unitOfWork.UserRepository.GetUserByIdAsync(id);
            return mapper.Map<UserDto>(result);
        }

        public async Task CreateAsync(UserDto item)
        {
            //TODO Create method in repository, which we can use for checking, if this object already exists
            var result = mapper.Map<User>(item);
            await unitOfWork.UserRepository.CreateAsync(result);
            await unitOfWork.SaveAsync();
        }
        public async Task DeleteAsync(int id)
        {
            var item = await unitOfWork.UserRepository.GetUserByIdAsync(id);
            if (item == null)
            {
                throw new ArgumentNullException(nameof(item), "Item is not found"); //TODO Try to create ExceptionHandlingMiddleware Later and own exceptions
            }

            await unitOfWork.UserRepository.DeleteAsync(item);
            await unitOfWork.SaveAsync();
        }

        public async Task UpdateAsync(UserDto item)
        {
            var result = mapper.Map<User>(item);
            await unitOfWork.UserRepository.UpdateAsync(result);
        }
    }
}
