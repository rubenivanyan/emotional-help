namespace PsychologicalAssistance.Core.Data.Entities
{
    public abstract class Materials<GenreType> : BaseEntity
    {
        public string Title { get; set; }
        public GenreType Genre { get; set; }
        public string Language { get; set; }
    }
}
