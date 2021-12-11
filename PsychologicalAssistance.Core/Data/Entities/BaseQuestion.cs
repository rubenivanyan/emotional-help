using System.ComponentModel.DataAnnotations;

namespace PsychologicalAssistance.Core.Data.Entities
{
    public abstract class BaseQuestion : BaseEntity
    {
        [Required]
        public string Formulation { get; set; }
    }
}
