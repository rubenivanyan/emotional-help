using System.Linq;

namespace PsychologicalAssistance.Core.Data.Seeding.DbInitializers
{
    public class RolesInitializer : IDbInitializers
    {
        public void Initialize(ApplicationDbContext dbContext)
        {
            if (dbContext.Roles.Any())
            {
                return;
            }

            dbContext.Roles.AddRange(DefaultObjects.IdentityRoles);
            dbContext.SaveChanges();
        }
    }
}
