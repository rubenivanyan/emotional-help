using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PsychologicalAssistance.Core.Data.DTOs
{
    public class MaterialsDto<GenreType> : BaseDto
    {
        public string Title { get; set; }
        public GenreType Genre { get; set; }
        public string Language { get; set; }
    }
}
