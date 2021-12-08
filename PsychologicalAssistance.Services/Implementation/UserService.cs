using PsychologicalAssistance.Core.Data.Enitities;
using PsychologicalAssistance.Core.Repositories.Interfaces;
using PsychologicalAssistance.Services.Abstract;
using PsychologicalAssistance.Services.Interfaces;

namespace PsychologicalAssistance.Services.Implementation
{
    public class UserService : BaseService<User>, IUserService
    {
        public UserService(IDataRepository<User> dataRepository) : base(dataRepository) { }
    }
}
