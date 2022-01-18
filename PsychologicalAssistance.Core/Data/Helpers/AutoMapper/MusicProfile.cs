using AutoMapper;
using PsychologicalAssistance.Core.Data.DTOs;
using PsychologicalAssistance.Core.Data.Entities;
using System;

namespace PsychologicalAssistance.Core.Data.Helpers.AutoMapper
{
    public class MusicProfile : Profile
    {
        public MusicProfile()
        {
            CreateMap<Music, MusicDto>()
                .ForMember(dest => dest.Genre, opt => opt.MapFrom(src => Enum.GetName(src.Genre)))
                .ReverseMap();
        }
    }
}
