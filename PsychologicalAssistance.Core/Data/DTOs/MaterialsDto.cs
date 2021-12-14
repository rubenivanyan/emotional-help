namespace PsychologicalAssistance.Core.Data.DTOs
{
    public class MaterialsDto<GenreType> : BaseDto
    {
        public string Title { get; set; }
        public GenreType Genre { get; set; }
        public string Language { get; set; }
    }
}
