using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PsychologicalAssistance.Core.Data.Configurations;
using PsychologicalAssistance.Core.Data.Entities;

namespace PsychologicalAssistance.Core.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Test> Tests { get; set; }
        public DbSet<Application> Applications { get; set; }
        public DbSet<Answer> Answers { get; set; }
        public DbSet<Variant> Variants { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<TestResults> TestResults { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Film> Films { get; set; }
        public DbSet<ComputerGame> ComputerGames { get; set; }
        public DbSet<Music> Musics { get; set; }
        public DbSet<Genre> Genres { get; set; }

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

            modelBuilder.ApplyConfiguration(new RoleConfiguration());
            /*modelBuilder.ApplyConfiguration(new FilmConfiguration());
            modelBuilder.ApplyConfiguration(new BookConfiguration());
            modelBuilder.ApplyConfiguration(new QuestionConfiguration());
            modelBuilder.ApplyConfiguration(new ComputerGameConfiguration());
            modelBuilder.ApplyConfiguration(new GenreConfiguration());
            modelBuilder.ApplyConfiguration(new MusicConfiguration());
            modelBuilder.ApplyConfiguration(new VariantConfiguration());*/
        }
    }
}
