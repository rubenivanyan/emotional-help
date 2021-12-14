using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PsychologicalAssistance.Core.Data.Entities;

namespace PsychologicalAssistance.Core.Data.Configurations
{
    public class QuestionConfiguration : IEntityTypeConfiguration<Question>
    {
        public void Configure(EntityTypeBuilder<Question> builder)
        {
            builder.HasData(
                new Question
                {
                    Id = 1,
                    Formulation = "How are you? Your mood?",
                    ImageUrl = "dasddsa@fsfdss"
                },
                new Question
                {
                    Id = 2,
                    Formulation = "What is your emotion now?",
                    ImageUrl = "dasddsa@fsfdss"
                },
                new Question
                {
                    Id = 3,
                    Formulation = "How do you feel now?",
                    ImageUrl = "dasddsa@fsfdss"
                }
                );
        }
    }
}
