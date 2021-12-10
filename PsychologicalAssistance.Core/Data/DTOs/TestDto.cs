using PsychologicalAssistance.Core.Enums;
using System.Collections.Generic;

namespace PsychologicalAssistance.Core.Data.DTOs
{
    public class TestDto : BaseDto
    {
        public string Title { get; set; }
        public TypeOfTests TypeOfTest { get; set; }
    }
}
