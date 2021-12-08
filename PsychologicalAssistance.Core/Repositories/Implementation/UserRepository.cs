using PsychologicalAssistance.Core.Data;
using PsychologicalAssistance.Core.Data.Enitities;
using PsychologicalAssistance.Core.Repositories.Abstract;
using PsychologicalAssistance.Core.Repositories.Interfaces;

namespace PsychologicalAssistance.Core.Repositories.Implementation
{
    public class UserRepository : DataRepository<User>, IUserRepository
    {
        public UserRepository(ApplicationDbContext dbContext) : base(dbContext) { }
    }
}
