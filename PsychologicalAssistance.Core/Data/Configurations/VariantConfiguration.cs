using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PsychologicalAssistance.Core.Data.Entities;

namespace PsychologicalAssistance.Core.Data.Configurations
{
    public class VariantConfiguration : IEntityTypeConfiguration<Variant>
    {
        public void Configure(EntityTypeBuilder<Variant> builder)
        {
            builder.HasData(
                new Variant
                {
                    Id = 1,
                    Formulation = "Happiness"
                },
                new Variant
                {
                    Id = 2,
                    Formulation = "Boredom"
                },
                new Variant
                {
                    Id = 3,
                    Formulation = "Certainty"
                },
                new Variant
                {
                    Id = 4,
                    Formulation = "Compassion"
                },
                new Variant
                {
                    Id = 5,
                    Formulation = "Disappointment"
                },
                new Variant
                {
                    Id = 6,
                    Formulation = "Embarrassment"
                }
            );
        }
    }
}
