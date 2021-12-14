using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PsychologicalAssistance.Core.Data.Entities;
using PsychologicalAssistance.Core.Enums;

namespace PsychologicalAssistance.Core.Data.Configurations
{
    public class ComputerGameConfiguration : IEntityTypeConfiguration<ComputerGame>
    {
        public void Configure(EntityTypeBuilder<ComputerGame> builder)
        {
            builder.HasData(
                new ComputerGame
                { 
                    Id = 1,
                    Company = "CDProjectRed",
                    Title = "The Witcher 3: Wild Hunt",
                    Genre = ComputerGameGenres.ActionRolePlaying,
                    Language = "RU",
                    Review = "93/100"
                },
                new ComputerGame
                {
                    Id = 2,
                    Company = "Rockstar",
                    Title = "Red Dead Redemption 2",
                    Genre = ComputerGameGenres.ActionAdventure,
                    Language = "EN",
                    Review = "97/100"
                }
                );
        }
    }
}
