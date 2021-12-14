using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PsychologicalAssistance.Core.Data.Entities;

namespace PsychologicalAssistance.Core.Data.Configurations
{
    public class EmotionGenreConfiguration : IEntityTypeConfiguration<EmotionGenre>
    {
        public void Configure(EntityTypeBuilder<EmotionGenre> builder)
        {
            builder.HasData(
                new EmotionGenre
                {
                    Id = 1,
                    Emotion = "Happiness",
                    Genre = "ActionRolePlaying"
                },
                new EmotionGenre
                {
                    Id = 2,
                    Emotion = "Boredom",
                    Genre = "ActionAdventure"
                },
                new EmotionGenre
                {
                    Id = 3,
                    Emotion = "Boredom",
                    Genre = "Action"
                },
                new EmotionGenre
                {
                    Id = 4,
                    Emotion = "Boredom",
                    Genre = "Fantasy"
                },
                new EmotionGenre
                {
                    Id = 5,
                    Emotion = "Compassion",
                    Genre = "Jazz"
                }
            );
        }
    }
}
