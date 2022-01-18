﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PsychologicalAssistance.Core.Data.Entities;

namespace PsychologicalAssistance.Core.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Test> Tests { get; set; }
        public DbSet<TestingApplication> Applications { get; set; }
        public DbSet<Answer> Answers { get; set; }
        public DbSet<Variant> Variants { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<TestResults> TestResults { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Film> Films { get; set; }
        public DbSet<ComputerGame> ComputerGames { get; set; }
        public DbSet<Music> Musics { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Training> Trainings { get; set; }
        public DbSet<ConsultingApplication> Consultings { get; set; }
        public DbSet<TrainingApplication> TrainingApplications { get; set; }
        public DbSet<QuestionGroupsValues> QuestionGroupsValues { get; set; }

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
