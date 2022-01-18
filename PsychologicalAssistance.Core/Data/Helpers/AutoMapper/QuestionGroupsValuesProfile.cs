using AutoMapper;
using PsychologicalAssistance.Core.Data.DTOs;
using PsychologicalAssistance.Core.Data.Entities;
using System;

namespace PsychologicalAssistance.Core.Data.Helpers.AutoMapper
{
    public class QuestionGroupsValuesProfile : Profile
    {
        public QuestionGroupsValuesProfile()
        {
            CreateMap<QuestionGroupsValues, QuestionGroupsValuesDto>()
                .ForMember(dest => dest.QuestionGroup, opts => opts.MapFrom(src => Enum.GetName(src.QuestionGroup)));
        }
    }
}
