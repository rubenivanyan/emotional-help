using PsychologicalAssistance.Core.Data;
using PsychologicalAssistance.Core.Data.Enitities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PsychologicalAssistance.Core.Repositories.Interfaces
{
    public interface IDataRepository<EntityType> where EntityType : BaseEntity
    {
        Task<IEnumerable<EntityType>> GetAllItemsAsync();
        Task<EntityType> GetItemByIdAsync(int id);
        Task CreateAsync(EntityType item);
        Task DeleteAsync(EntityType item);
        Task UpdateAsync(EntityType item);
    }
}
