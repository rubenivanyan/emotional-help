using PsychologicalAssistance.Core.Data.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PsychologicalAssistance.Services.Interfaces
{
    public interface IBaseService<EntityType> where EntityType : BaseEntity
    {
        Task<IEnumerable<EntityType>> GetAllItemsAsync();
        Task<EntityType> GetItemByIdAsync(int id);
        Task CreateAsync(EntityType item);
        Task DeleteAsync(int id);
        Task UpdateAsync(EntityType item);
    }
}
