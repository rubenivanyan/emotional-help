using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PsychologicalAssistance.Core.Data.Entities
{
    public class User : IdentityUser
    {
        [Required]
        public string UserSurname { get; set; }
        
        [Required]
        public DateTime BirthDate { get; set; }
        
        public List<TestResults> TestResults { get; set; }
    }
}
