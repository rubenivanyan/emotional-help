using AutoMapper;
using PsychologicalAssistance.Core.Data.DTOs;
using PsychologicalAssistance.Core.Data.Entities;

namespace PsychologicalAssistance.Core.Data.Helpers.AutoMapper
{
    public class TestingApplicationProfile : Profile
    {
        public TestingApplicationProfile()
        {
            CreateMap<TestingApplication, TestingApplicationDto>().ReverseMap();
        }
    }
}
