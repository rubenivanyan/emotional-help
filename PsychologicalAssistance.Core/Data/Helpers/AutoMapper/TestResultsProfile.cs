using AutoMapper;
using PsychologicalAssistance.Core.Data.DTOs;
using PsychologicalAssistance.Core.Data.Entities;

namespace PsychologicalAssistance.Core.Data.Helpers.AutoMapper
{
    public class TestResultsProfile : Profile
    {
        public TestResultsProfile()
        {
            CreateMap<TestResults, TestResultsDto>().ReverseMap();
        }
    }
}
