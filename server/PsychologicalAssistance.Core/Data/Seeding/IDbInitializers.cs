namespace PsychologicalAssistance.Core.Data.Seeding
{
    public interface IDbInitializers
    {
        void Initialize(ApplicationDbContext dbContext);
    }
}
