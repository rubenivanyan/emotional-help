using PsychologicalAssistance.Core.Data.Enitities;
using PsychologicalAssistance.Core.Repositories.Interfaces;
using PsychologicalAssistance.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PsychologicalAssistance.Services.Abstract
{
    public class BaseService<EntityType> : IBaseService<EntityType> where EntityType : BaseEntity
    {
        protected IDataRepository<EntityType> DataRepository { get; set; }

        public BaseService(IDataRepository<EntityType> dataRepository)
        {
            DataRepository = dataRepository;
        }

        public async Task CreateAsync(EntityType item)
        {
            //TODO Create method in repository, which we can use for checking, if this object already exists
            await DataRepository.CreateAsync(item);
        }

        public async Task DeleteAsync(int id)
        {
            var item = await DataRepository.GetItemByIdAsync(id);
            if (item == null)
                throw new ArgumentException("Item not found"); //TODO Try to create ExceptionHandlingMiddleware Later and own exceptions

            await DataRepository.DeleteAsync(item);
        }

        public async Task<EntityType> GetItemByIdAsync(int id)
            => await DataRepository.GetItemByIdAsync(id);

        public async Task<IEnumerable<EntityType>> GetAllItemsAsync()
            => await DataRepository.GetAllItemsAsync();

        public async Task UpdateAsync(EntityType item)
            => await DataRepository.UpdateAsync(item);
    }
}
