using PsychologicalAssistance.Core.Enums;


namespace PsychologicalAssistance.Core.Data.Enitities
{
    public class Question : BaseEntity
    {

        public string Formulation { get; set; }
        public Categories Category { get; set; }
        public Seniorities Seniority { get; set; }
    }
}
