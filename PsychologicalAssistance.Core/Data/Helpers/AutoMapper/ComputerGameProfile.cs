using AutoMapper;
using PsychologicalAssistance.Core.Data.DTOs;
using PsychologicalAssistance.Core.Data.Entities;
using PsychologicalAssistance.Core.Enums;
using System;

namespace PsychologicalAssistance.Core.Data.Helpers.AutoMapper
{
    public class ComputerGameProfile : Profile
    {
        public ComputerGameProfile()
        {
            CreateMap<ComputerGame, ComputerGameDto>()
                .ForMember(dest => dest.Genre, opt => opt.MapFrom(src => Enum.GetName(src.Genre)))
                .ReverseMap();
        }
    }
}
