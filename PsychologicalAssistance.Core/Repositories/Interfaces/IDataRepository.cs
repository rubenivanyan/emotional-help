using PsychologicalAssistance.Core.Data.Enitities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PsychologicalAssistance.Core.Repositories.Interfaces
{
    public interface IDataRepository<EntityType> where EntityType : BaseEntity
    {
        Task<IEnumerable<EntityType>> GetAllItemsAsync();
        Task<EntityType> GetItemByIdAsync(object id);
        Task CreateAsync(EntityType item);
        Task DeleteAsync(EntityType item);
        Task UpdateAsync(EntityType item);
    }
}
