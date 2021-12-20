using System.ComponentModel.DataAnnotations.Schema;

namespace PsychologicalAssistance.Core.Data.Entities
{
    public class TrainingApplication : BaseEntity
    {
        [ForeignKey("User")]
        public string UserId { get; set; }
        public User User { get; set; }
        [ForeignKey("Training")]
        public int TrainingId { get; set; }
        public Training Training { get; set; }
        public string UserFullName { get; set; }
        public string Email { get; set; }
    }
}
