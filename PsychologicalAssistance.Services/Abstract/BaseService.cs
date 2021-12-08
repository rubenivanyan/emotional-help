using PsychologicalAssistance.Core.Data.Enitities;
using PsychologicalAssistance.Core.Repositories.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PsychologicalAssistance.Services.Abstract
{
    public class BaseService<EntityType> where EntityType : BaseEntity
    {
        protected IDataRepository<EntityType> DataRepository { get; set; }

        public BaseService(IDataRepository<EntityType> dataRepository)
        {
            DataRepository = dataRepository;
        }
        
        public async Task CreateAsync(EntityType item)
            => await DataRepository.CreateAsync(item);

        public async Task DeleteAsync(EntityType item)
            => await DataRepository.DeleteAsync(item);

        public async Task<EntityType> GetItemByIdAsync(int id)
            => await DataRepository.GetItemByIdAsync(id);

        public async Task<IEnumerable<EntityType>> GetAllItemsAsync()
            => await DataRepository.GetAllItemsAsync();

        public async Task UpdateAsync(EntityType item)
            => await DataRepository.UpdateAsync(item);
    }
}
