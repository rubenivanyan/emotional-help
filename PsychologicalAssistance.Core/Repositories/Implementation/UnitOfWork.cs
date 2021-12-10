using PsychologicalAssistance.Core.Data;
using PsychologicalAssistance.Core.Data.Enitities;
using PsychologicalAssistance.Core.Repositories.Abstract;
using PsychologicalAssistance.Core.Repositories.Interfaces;
using System;
using System.Threading.Tasks;

namespace PsychologicalAssistance.Core.Repositories.Implementation
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly ApplicationDbContext dbContext;
        private IUserRepository userRepository;
        private IDataRepository<BaseEntity> dataRepository;

        public UnitOfWork(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public IUserRepository UserRepository => userRepository ??= new UserRepository(dbContext);

        public IDataRepository<BaseEntity> DataRepository => dataRepository ??= new DataRepository<BaseEntity>(dbContext);

        public async Task<int> SaveAsync()
        {
            return await dbContext.SaveChangesAsync();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (dbContext is null)
                {
                    dbContext.Dispose();
                }
            }
        }
    }
}
