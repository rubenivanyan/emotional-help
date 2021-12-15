using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PsychologicalAssistance.Core.Data.Entities;
using PsychologicalAssistance.Core.Data.Seeding;

namespace PsychologicalAssistance.Core.Data.Configurations
{
	public class QuestionConfiguration : IEntityTypeConfiguration<Question>
	{
		public void Configure(EntityTypeBuilder<Question> builder)
			=> builder.HasData(DefaultObjects.QuestionsObjects);
	}
}
