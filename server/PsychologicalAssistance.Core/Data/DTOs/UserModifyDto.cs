using System.ComponentModel.DataAnnotations;

namespace PsychologicalAssistance.Core.Data.DTOs
{
    public class UserModifyDto
    {
        [Required]
        public string UserName { get; set; }

        [Required]
        public string UserSurname { get; set; }

        [Required]
        public string BirthDate { get; set; }

        [Required]
        public string Email { get; set; }
    }
}
