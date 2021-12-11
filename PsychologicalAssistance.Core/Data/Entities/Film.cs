using System;
using PsychologicalAssistance.Core.Enums;
using System.Collections.Generic;


namespace PsychologicalAssistance.Core.Data.Entities
{
    public class Film : Materials<FilmGenres>
    {
        public DateTime Year { get; set; }
        public string Producer { get; set; }
        public List<string> MainRoles { get; set; }
        
        public int FilmDuraction { get; set; }
        public string Country { get; set; }
    }
}
