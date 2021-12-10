using Microsoft.EntityFrameworkCore;
using PsychologicalAssistance.Core.Data;
using PsychologicalAssistance.Core.Data.Enitities;
using PsychologicalAssistance.Core.Repositories.Abstract;
using PsychologicalAssistance.Core.Repositories.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PsychologicalAssistance.Core.Repositories.Implementation
{
    public class UserRepository : DataRepository<User>, IUserRepository
    {
        //private readonly IMapper _mapper;

        private readonly DbSet<User> dbSet;

        public UserRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            //_mapper = mapper;
            dbSet = dbContext.Set<User>();
        }

        public async Task<User> GetUserByIdAsync(int id)
        {
            var user = await GetItemByIdAsync(id);
            if (user == null)
            {
                return null;
            }

            //var userDto = _mapper.Map<UserDto>(user);
            return user;
        }

        public async Task<User> GetUserByEmailAsync(string email)
        {
            var user = await dbSet.FindAsync(email);

            if (user is not null)
            {
                return user;
            }

            return null;
        }

        public async Task<IEnumerable<User>> GetAllUsersAsync()
        {
            var users = await GetAllItemsAsync();
            if (users == null)
            {
                return null;
            }

            return users;
        }
    }
}
