using Microsoft.EntityFrameworkCore;
using PsychologicalAssistance.Core.Data;
using PsychologicalAssistance.Core.Data.Seeding;

namespace PsychologicalAssistance.Tests.Common
{
    public class InMemoryDatabaseCreation
    {
        protected static object LockObject = new object();
        protected static bool IsInitialized;
        protected DbContextOptions<ApplicationDbContext> dbContextOptions;

        protected virtual void Setup()
        {
            dbContextOptions = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(databaseName: "PsychologyAssistanceInMemoryDatabaseForTesting").Options;

            if (!IsInitialized)
            {
                lock(LockObject)
                {
                    using(var context = new ApplicationDbContext(dbContextOptions))
                    {
                        Initializer.Initialize(context);
                    }
                }
            }
        }
    }
}
