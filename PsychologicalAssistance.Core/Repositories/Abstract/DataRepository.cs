using Microsoft.EntityFrameworkCore;
using PsychologicalAssistance.Core.Data;
using PsychologicalAssistance.Core.Data.Entities;
using PsychologicalAssistance.Core.Repositories.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PsychologicalAssistance.Core.Repositories.Abstract
{
    public class DataRepository<EntityType> : IDataRepository<EntityType> where EntityType : BaseEntity
    {
        protected ApplicationDbContext DbContext { get; set; }

        protected DbSet<EntityType> DbSet { get; set; }

        public DataRepository(ApplicationDbContext dbContext)
        {
            DbContext = dbContext;
            DbSet = DbContext.Set<EntityType>();
        }

        public async Task<IEnumerable<EntityType>> GetAllItemsAsync()
            => await DbSet.ToListAsync<EntityType>();


        public async Task<EntityType> GetItemByIdAsync(object id)
            => await DbSet.FindAsync(id);

        public async Task CreateAsync(EntityType item)
        {
            item.Id = 0;
            await DbSet.AddAsync(item);
        }

        public async Task DeleteAsync(EntityType item)
        {
             await Task.Run(() => DbSet.Remove(item));
        }

        public async Task UpdateAsync(EntityType item)
        {
            await Task.Run(() => DbSet.Update(item));
        }
    }
}
