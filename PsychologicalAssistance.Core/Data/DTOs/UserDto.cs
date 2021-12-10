using PsychologicalAssistance.Core.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace PsychologicalAssistance.Core.Data.DTOs
{
    public class UserDto : BaseDto
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }
        [Required]
        public string MailAddress { get; set; }
        [Required]
        public DateTime BirthDate { get; set; }
        public Roles Role { get; set; }
    }
}
