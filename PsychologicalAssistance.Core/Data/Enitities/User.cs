﻿using PsychologicalAssistance.Core.Enums;
using System;

namespace PsychologicalAssistance.Core.Data.Enitities
{
    public class User : BaseEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BirthDate { get; set; }
        public Roles Role { get; set; }
    }
}
