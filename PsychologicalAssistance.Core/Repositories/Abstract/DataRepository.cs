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
        protected ApplicationDbContext DbContext { get; set; }

        protected DbSet<EntityType> DbSet { get; set; }

        public DataRepository(ApplicationDbContext dbContext)
        {
            DbContext = dbContext;
            DbSet = DbContext.Set<EntityType>();
        }

        public async Task<IEnumerable<EntityType>> GetAllItemsAsync()
            => await DbSet.ToListAsync<EntityType>();


        public async Task<EntityType> GetItemByIdAsync(int id)
            => await DbSet.FirstOrDefaultAsync<EntityType>();

        public async Task CreateAsync(EntityType item)
        {
            DbSet.Add(item);
            await SaveAsync();
        }

        public async Task DeleteAsync(EntityType item)
        {
            DbSet.Remove(item);
            await SaveAsync();
        }

        public async Task UpdateAsync(EntityType item)
        {
            DbSet.Update(item);
            await SaveAsync();
        }

        public async Task SaveAsync()
            => await DbContext.SaveChangesAsync();
    }
}
