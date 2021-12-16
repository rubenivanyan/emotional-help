using AutoMapper;
using PsychologicalAssistance.Core.Data.DTOs;
using PsychologicalAssistance.Core.Data.Entities;
using System;

namespace PsychologicalAssistance.Core.Data.Helpers.AutoMapper
{
    public class FilmProfile : Profile
    {
        public FilmProfile()
        {
            CreateMap<Film, FilmDto>()
                .ForMember(dest => dest.Year, opt => opt.MapFrom(src => src.Year.Year))
                .ForMember(dest => dest.Genre, opt => opt.MapFrom(src => Enum.GetName(src.Genre)));

            CreateMap<FilmDto, Film>()
                .ForMember(dest => dest.Genre, opt => opt.MapFrom(src => src.Genre))
                .ForMember(dest => dest.Year, opt => opt.MapFrom(src => DateTime.Parse(src.Year)));
        }
    }
}
