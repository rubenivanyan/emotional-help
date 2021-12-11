using System;
using System.ComponentModel.DataAnnotations;

namespace PsychologicalAssistance.Core.Data.DTOs
{
    public class TestResultsDto : BaseDto
    {
        public DateTime DateOfResults { get; set; }

        [Required]
        public int UserId { get; set; }

        [Required]
        public int TestId { get; set; }
    }
}
