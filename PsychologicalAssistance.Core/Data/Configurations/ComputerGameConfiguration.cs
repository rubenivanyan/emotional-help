using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PsychologicalAssistance.Core.Data.Entities;
using PsychologicalAssistance.Core.Data.Seeding;

namespace PsychologicalAssistance.Core.Data.Configurations
{
    public class ComputerGameConfiguration : IEntityTypeConfiguration<ComputerGame>
    {
        public void Configure(EntityTypeBuilder<ComputerGame> builder)
            => builder.HasData(DefaultObjects.ComputerGamesObjects);
    }
}
