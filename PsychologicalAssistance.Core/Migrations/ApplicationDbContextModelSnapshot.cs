﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PsychologicalAssistance.Core.Data;

namespace PsychologicalAssistance.Core.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("PsychologicalAssistance.Core.Data.Entities.Answer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Formulation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("QuestionId")
                        .HasColumnType("int");

                    b.Property<int>("TestResultsId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("QuestionId");

                    b.HasIndex("TestResultsId");

                    b.ToTable("Answers");
                });

            modelBuilder.Entity("PsychologicalAssistance.Core.Data.Entities.Application", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<bool>("IsArchived")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Applications");
                });

            modelBuilder.Entity("PsychologicalAssistance.Core.Data.Entities.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Author")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Genre")
                        .HasColumnType("int");

                    b.Property<string>("Language")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Author = "Imbolo Mbue",
                            Genre = 5,
                            Language = "EN",
                            Title = "How Beautiful We Were"
                        },
                        new
                        {
                            Id = 2,
                            Author = "Katie Kitamura",
                            Genre = 5,
                            Language = "EN",
                            Title = "Intimacies"
                        },
                        new
                        {
                            Id = 3,
                            Author = "Michael Connelly",
                            Genre = 0,
                            Language = "EN",
                            Title = "The Dark Hours"
                        });
                });

            modelBuilder.Entity("PsychologicalAssistance.Core.Data.Entities.Film", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FilmDuraction")
                        .HasColumnType("int");

                    b.Property<int>("Genre")
                        .HasColumnType("int");

                    b.Property<string>("Language")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Producer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VideoUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Year")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Films");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Country = "USA",
                            FilmDuraction = 0,
                            Genre = 4,
                            Language = "EN",
                            Title = "The Godfather",
                            VideoUrl = "google.com",
                            Year = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1972)
                        },
                        new
                        {
                            Id = 2,
                            Country = "USA",
                            FilmDuraction = 0,
                            Genre = 4,
                            Language = "EN",
                            Title = "The Shawshank Redemption",
                            VideoUrl = "www.facebook.com",
                            Year = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1994)
                        },
                        new
                        {
                            Id = 3,
                            Country = "USA",
                            FilmDuraction = 0,
                            Genre = 1,
                            Language = "EN",
                            Title = "The Dark Knight",
                            VideoUrl = "www.twitter.com",
                            Year = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(2008)
                        });
                });

            modelBuilder.Entity("PsychologicalAssistance.Core.Data.Entities.Music", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Executor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Genre")
                        .HasColumnType("int");

                    b.Property<string>("Language")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Musics");
                });
                
            modelBuilder.Entity("PsychologicalAssistance.Core.Data.Entities.ComputerGame", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Company")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Genre")
                        .HasColumnType("int");

                    b.Property<string>("Language")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Review")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ComputerGames");
                });

            modelBuilder.Entity("PsychologicalAssistance.Core.Data.Entities.Question", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Formulation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TestId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TestId");

                    b.ToTable("Questions");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Formulation = "How are you? Your mood?",
                            ImageUrl = "dasddsa@fsfdss"
                        },
                        new
                        {
                            Id = 2,
                            Formulation = "What is your emotion now?",
                            ImageUrl = "dasddsa@fsfdss"
                        },
                        new
                        {
                            Id = 3,
                            Formulation = "How do you feel now?",
                            ImageUrl = "dasddsa@fsfdss"
                        });
                });

            modelBuilder.Entity("PsychologicalAssistance.Core.Data.Entities.Test", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TypeOfTest")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Tests");
                });

            modelBuilder.Entity("PsychologicalAssistance.Core.Data.Entities.TestResults", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("ResultsDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("TestId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TestId");

                    b.HasIndex("UserId");

                    b.ToTable("TestResults");
                });

            modelBuilder.Entity("PsychologicalAssistance.Core.Data.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("MailAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BirthDate = new DateTime(2021, 12, 12, 10, 54, 49, 155, DateTimeKind.Local).AddTicks(1450),
                            MailAddress = "123123@sad",
                            Name = "Tom",
                            Role = 3,
                            Surname = "Ivanov"
                        },
                        new
                        {
                            Id = 2,
                            BirthDate = new DateTime(2021, 12, 12, 10, 54, 49, 155, DateTimeKind.Local).AddTicks(8575),
                            MailAddress = "dasdas@sad",
                            Name = "Alice",
                            Role = 1,
                            Surname = "Denisov"
                        },
                        new
                        {
                            Id = 3,
                            BirthDate = new DateTime(2021, 12, 12, 10, 54, 49, 155, DateTimeKind.Local).AddTicks(8586),
                            MailAddress = "asdsadas3123@sad",
                            Name = "Sam",
                            Role = 0,
                            Surname = "Donikas"
                        });
                });

            modelBuilder.Entity("PsychologicalAssistance.Core.Data.Entities.Variant", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Formulation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Variants");
                });

            modelBuilder.Entity("QuestionVariant", b =>
                {
                    b.Property<int>("QuestionsId")
                        .HasColumnType("int");

                    b.Property<int>("VariantsId")
                        .HasColumnType("int");

                    b.HasKey("QuestionsId", "VariantsId");

                    b.HasIndex("VariantsId");

                    b.ToTable("QuestionVariant");
                });

            modelBuilder.Entity("PsychologicalAssistance.Core.Data.Entities.Answer", b =>
                {
                    b.HasOne("PsychologicalAssistance.Core.Data.Entities.Question", "Question")
                        .WithMany()
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PsychologicalAssistance.Core.Data.Entities.TestResults", "TestResults")
                        .WithMany("Answers")
                        .HasForeignKey("TestResultsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Question");

                    b.Navigation("TestResults");
                });

            modelBuilder.Entity("PsychologicalAssistance.Core.Data.Entities.Question", b =>
                {
                    b.HasOne("PsychologicalAssistance.Core.Data.Entities.Test", null)
                        .WithMany("Questions")
                        .HasForeignKey("TestId");
                });

            modelBuilder.Entity("PsychologicalAssistance.Core.Data.Entities.TestResults", b =>
                {
                    b.HasOne("PsychologicalAssistance.Core.Data.Entities.Test", "Test")
                        .WithMany()
                        .HasForeignKey("TestId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PsychologicalAssistance.Core.Data.Entities.User", "User")
                        .WithMany("TestResults")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Test");

                    b.Navigation("User");
                });

            modelBuilder.Entity("QuestionVariant", b =>
                {
                    b.HasOne("PsychologicalAssistance.Core.Data.Entities.Question", null)
                        .WithMany()
                        .HasForeignKey("QuestionsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PsychologicalAssistance.Core.Data.Entities.Variant", null)
                        .WithMany()
                        .HasForeignKey("VariantsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PsychologicalAssistance.Core.Data.Entities.Test", b =>
                {
                    b.Navigation("Questions");
                });

            modelBuilder.Entity("PsychologicalAssistance.Core.Data.Entities.TestResults", b =>
                {
                    b.Navigation("Answers");
                });

            modelBuilder.Entity("PsychologicalAssistance.Core.Data.Entities.User", b =>
                {
                    b.Navigation("TestResults");
                });
#pragma warning restore 612, 618
        }
    }
}
