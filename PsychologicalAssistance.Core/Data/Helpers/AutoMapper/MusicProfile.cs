using AutoMapper;
using PsychologicalAssistance.Core.Data.DTOs;
using PsychologicalAssistance.Core.Data.Entities;

namespace PsychologicalAssistance.Core.Data.Helpers.AutoMapper
{
    public class MusicProfile : Profile
    {
        public MusicProfile()
        {
            CreateMap<Music, MusicDto>().ReverseMap();
        }
    }
}
