using Microsoft.EntityFrameworkCore;

namespace PsychologicalAssistance.Core.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
    }
}
