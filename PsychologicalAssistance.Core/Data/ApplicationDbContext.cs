using Microsoft.EntityFrameworkCore;
using PsychologicalAssistance.Core.Data.Entities;

namespace PsychologicalAssistance.Core.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Test> Tests { get; set; }
        public DbSet<Application> Applications { get; set; }
        public DbSet<Answer> Answers { get; set; }
        public DbSet<Variant> Variants { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<TestResults> TestResults { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<ComputerGame> ComputerGames { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Answer>()
                .HasOne(q => q.Question)
                .WithMany();

            modelBuilder.Entity<TestResults>()
                .HasOne(u => u.User)
                .WithMany(t => t.TestResults);

            modelBuilder.Entity<TestResults>()
                .HasOne(t => t.Test)
                .WithMany();

            modelBuilder.Entity<Answer>()
                .HasOne(t => t.TestResults)
                .WithMany(a => a.Answers);

            base.OnModelCreating(modelBuilder);
        }
    }
}
