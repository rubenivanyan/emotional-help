using System;
using PsychologicalAssistance.Core.Enums;

namespace PsychologicalAssistance.Core.Data.DTOs
{
    public class FilmDto : MaterialsDto
    {
        public string Year { get; set; }
        public string VideoUrl { get; set; }
    }
}
