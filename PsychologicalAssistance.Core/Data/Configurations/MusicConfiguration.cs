using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PsychologicalAssistance.Core.Data.Entities;
using PsychologicalAssistance.Core.Enums;

namespace PsychologicalAssistance.Core.Data.Configurations
{
    public class MusicConfiguration : IEntityTypeConfiguration<Music>
    {
        public void Configure(EntityTypeBuilder<Music> builder)
        {
            builder.HasData(
                new Music
                {
                    Id = 1,
                    Title = "A Jolly Christmas from Frank Sinatra",
                    Executor = "Frank Sinatra",
                    Genre = MusicGenres.Jazz,
                    Language = "EN"
                }
            );
        }
    }
}
