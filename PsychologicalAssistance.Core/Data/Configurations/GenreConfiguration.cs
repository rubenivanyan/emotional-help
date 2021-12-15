using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PsychologicalAssistance.Core.Data.Entities;
using PsychologicalAssistance.Core.Data.Seeding;

namespace PsychologicalAssistance.Core.Data.Configurations
{
    public class GenreConfiguration : IEntityTypeConfiguration<Genre>
    {
        public void Configure(EntityTypeBuilder<Genre> builder)
            => builder.HasData(DefaultObjects.GenresObjects);
    }
}
