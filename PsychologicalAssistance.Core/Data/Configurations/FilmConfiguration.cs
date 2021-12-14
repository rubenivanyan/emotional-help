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
    public class FilmConfiguration : IEntityTypeConfiguration<Film>
    {
        public void Configure(EntityTypeBuilder<Film> builder)
        {
            builder.HasData(
                new Film
                {
                    Id = 1,
                    Title = "The Godfather",
                    Genre = FilmGenres.Drama,
                    Country = "USA",
                    Year = new DateTime(1972),
                    Language = "EN",
                    VideoUrl = "google.com"
                },
                new Film
                {
                    Id = 2,
                    Title = "The Shawshank Redemption",
                    Genre = FilmGenres.Drama,
                    Country = "USA",
                    Year = new DateTime(1994),
                    Language = "EN",
                    VideoUrl = "www.facebook.com"
                },
                new Film
                {
                    Id = 3,
                    Title = "The Dark Knight",
                    Genre = FilmGenres.Action,
                    Country = "USA",
                    Year = new DateTime(2008),
                    Language = "EN",
                    VideoUrl = "www.twitter.com"
                }
                );
        }
    }
}
