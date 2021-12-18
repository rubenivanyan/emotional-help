using AutoMapper;
using PsychologicalAssistance.Core.Data.DTOs;
using PsychologicalAssistance.Core.Data.Entities;
using System;

namespace PsychologicalAssistance.Core.Data.Helpers.AutoMapper
{
    public class QuestionProfile : Profile
    {
        public QuestionProfile()
        {
            CreateMap<Question, QuestionDto>()
                .ForMember(dest => dest.QuestionGroup, opts => opts.MapFrom(src => Enum.GetName(src.QuestionGroup)));

            CreateMap<QuestionDto, Question>()
                .ForMember(dest => dest.QuestionGroup, opts => opts.MapFrom(src => src.QuestionGroup));


            CreateMap<Question, FullQuestionDto>()
                .ForMember(dest => dest.QuestionGroup, opts => opts.MapFrom(src => Enum.GetName(src.QuestionGroup)));
            
            CreateMap<FullQuestionDto, Question>()
                .ForMember(dest => dest.QuestionGroup, opts => opts.MapFrom(src => src.QuestionGroup));
        }
    }
}
