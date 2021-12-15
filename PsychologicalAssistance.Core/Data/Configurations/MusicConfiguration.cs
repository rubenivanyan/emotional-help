using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PsychologicalAssistance.Core.Data.Entities;
using PsychologicalAssistance.Core.Data.Seeding;

namespace PsychologicalAssistance.Core.Data.Configurations
{
    public class MusicConfiguration : IEntityTypeConfiguration<Music>
    {
        public void Configure(EntityTypeBuilder<Music> builder)
            => builder.HasData(DefaultObjects.MusicObjects);
    }
}
