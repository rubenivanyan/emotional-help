using Microsoft.EntityFrameworkCore;
using PsychologicalAssistance.Core.Data.Enitities;

namespace PsychologicalAssistance.Core.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Test> Tests { get; set; }
        public DbSet<Application> Applications { get; set; }
    }
}
