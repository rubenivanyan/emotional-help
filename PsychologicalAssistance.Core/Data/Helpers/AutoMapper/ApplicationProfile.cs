using AutoMapper;
using PsychologicalAssistance.Core.Data.DTOs;
using PsychologicalAssistance.Core.Data.Entities;

namespace PsychologicalAssistance.Core.Data.Helpers.AutoMapper
{
    public class ApplicationProfile : Profile
    {
        public ApplicationProfile()
        {
            CreateMap<TestingApplication, ApplicationDto>().ReverseMap();
        }
    }
}
