using AutoMapper;
using PsychologicalAssistance.Core.Data.DTOs;
using PsychologicalAssistance.Core.Data.Entities;

namespace PsychologicalAssistance.Core.Data.Helpers.AutoMapper
{
    public class ComputerGameProfile : Profile
    {
        public ComputerGameProfile()
        {
            CreateMap<ComputerGame, ComputerGameDto>().ReverseMap();
        }
    }
}
