using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PsychologicalAssistance.Core.Data.Entities;

namespace PsychologicalAssistance.Core.Data.Configurations
{
    public class GenreConfiguration : IEntityTypeConfiguration<Genre>
    {
        public void Configure(EntityTypeBuilder<Genre> builder)
        {
            builder.HasData(
                new Genre
                {
                    Id = 1,
                    Title = "ActionRolePlaying"
                },
                new Genre
                {
                    Id = 2,
                    Title = "ActionAdventure"
                },
                new Genre
                {
                    Id = 3,
                    Title = "Action"
                },
                new Genre
                {
                    Id = 4,
                    Title = "Fantasy"
                },
                new Genre
                {
                    Id = 5,
                    Title = "Jazz"
                }
            );
        }
    }
}
