using PsychologicalAssistance.Core.Data.Entities;
using PsychologicalAssistance.Core.Repositories.Interfaces;
using PsychologicalAssistance.Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PsychologicalAssistance.Services.Abstract
{
    public class BaseService<EntityType> : IBaseService<EntityType> where EntityType : BaseEntity
    {

        protected IDataRepository<EntityType> DataRepository { get; set; }
        protected IUnitOfWork _unitOfWork { get; set; }

        public BaseService(IDataRepository<EntityType> dataRepository, IUnitOfWork unitOfWork)
        {
            DataRepository = dataRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task CreateAsync(EntityType item)
        {
            await DataRepository.CreateAsync(item);
            await _unitOfWork.CommitAsync();
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var item = await DataRepository.GetItemByIdAsync(id);
            if (item == null)
            {
                return false;
            }
            await DataRepository.DeleteAsync(item);
            await _unitOfWork.CommitAsync();
            return true;
        }

        public async Task<EntityType> GetItemByIdAsync(int id)
        {
            var item = await DataRepository.GetItemByIdAsync(id);
            return item;
        }

        public async Task<IEnumerable<EntityType>> GetAllItemsAsync()
        {
            var items = await DataRepository.GetAllItemsAsync();
            return items;
        }

        public async Task UpdateAsync(EntityType item)
        {
            await DataRepository.UpdateAsync(item);
            await _unitOfWork.CommitAsync();
        }
    }
}
