using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PsychologicalAssistance.Core.Data.Entities;
using PsychologicalAssistance.Core.Data.Seeding;

namespace PsychologicalAssistance.Core.Data.Configurations
{
    public class BookConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
            => builder.HasData(DefaultObjects.BooksObjects);
    }
}
