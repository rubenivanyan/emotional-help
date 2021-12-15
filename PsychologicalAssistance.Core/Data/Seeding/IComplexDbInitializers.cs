namespace PsychologicalAssistance.Core.Data.Seeding
{
    public interface IComplexDbInitializers
    {
        void Initialize(ApplicationDbContext dbContext);
    }
}
