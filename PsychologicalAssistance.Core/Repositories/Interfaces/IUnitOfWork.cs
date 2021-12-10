using PsychologicalAssistance.Core.Data.Enitities;
using System.Threading.Tasks;

namespace PsychologicalAssistance.Core.Repositories.Interfaces
{
    public interface IUnitOfWork 
    {
        IUserRepository UserRepository { get; }
        IDataRepository<BaseEntity> DataRepository { get; }
        Task<int> SaveAsync();
    }
}
