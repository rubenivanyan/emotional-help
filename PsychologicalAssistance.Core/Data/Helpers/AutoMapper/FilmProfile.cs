using AutoMapper;
using PsychologicalAssistance.Core.Data.DTOs;
using PsychologicalAssistance.Core.Data.Entities;

namespace PsychologicalAssistance.Core.Data.Helpers.AutoMapper
{
    public class FilmProfile : Profile
    {
        public FilmProfile()
        {
            CreateMap<Film, FilmDto>().ReverseMap();
        }
    }
}
