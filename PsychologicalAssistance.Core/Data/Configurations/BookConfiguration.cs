using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PsychologicalAssistance.Core.Data.Entities;
using PsychologicalAssistance.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PsychologicalAssistance.Core.Data.Configurations
{
    public class BookConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasData(
                new Book
                {
                    Id = 1,
                    Title = "How Beautiful We Were",
                    Genre = BookGenres.Novel,
                    Language = "EN",
                    Author = "Imbolo Mbue"
                },
                new Book
                {
                    Id = 2,
                    Title = "Intimacies",
                    Genre = BookGenres.Novel,
                    Language = "EN",
                    Author = "Katie Kitamura"
                },
                new Book
                {
                    Id = 3,
                    Title = "The Dark Hours",
                    Genre = BookGenres.Detective,
                    Language = "EN",
                    Author = "Michael Connelly"
                }
                );
        }
    }
}
