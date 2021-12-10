using Microsoft.EntityFrameworkCore;
using PsychologicalAssistance.Core.Data;
using PsychologicalAssistance.Core.Data.Enitities;
using PsychologicalAssistance.Core.Repositories.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PsychologicalAssistance.Core.Repositories.Abstract
{
    public class DataRepository<EntityType> : IDataRepository<EntityType> where EntityType : BaseEntity
    {
        private readonly DbSet<EntityType> dbSet;

        public DataRepository(ApplicationDbContext dbContext)
        {
            dbSet = dbContext.Set<EntityType>();
        }

        public async Task<IEnumerable<EntityType>> GetAllItemsAsync()
        {
            return dbSet.AsNoTracking();
        }

        public async Task<EntityType> GetItemByIdAsync(int id)
        {
            return await dbSet.FindAsync(id);
        }

        public async Task CreateAsync(EntityType item)
        {
            //item.Id = 0;
            await dbSet.AddAsync(item);
        }

        public async Task DeleteAsync(EntityType item)
        {
            dbSet.Remove(item);
        }

        public async Task UpdateAsync(EntityType item)
        {
            dbSet.Update(item);
        }
    }
}
