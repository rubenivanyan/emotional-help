using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PsychologicalAssistance.Core.Data.DTOs
{
    public class FilmDto : BaseDto
    {
        public string Title { get; set; }
        public DateTime Year { get; set; }
        public string VideoUrl { get; set; }
    }
}
