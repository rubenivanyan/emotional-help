using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PsychologicalAssistance.Core.Data.Enitities
{
    public abstract class BaseEntity
    {
        [Key]
        public int Id { get; set; }
    }
}
