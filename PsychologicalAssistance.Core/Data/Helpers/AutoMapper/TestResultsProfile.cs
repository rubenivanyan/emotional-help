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
            CreateMap<TestResults, TestResultsForUserDto>()
                .ForMember(u => u.UserFullName, opts => opts.MapFrom(s => s.User.UserName + s.User.UserSurname))
                .ForMember(t => t.Questions, opts => opts.MapFrom(s => s.Test.Questions));
        }
    }
}
