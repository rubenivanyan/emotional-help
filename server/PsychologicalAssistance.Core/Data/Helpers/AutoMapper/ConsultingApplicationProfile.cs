using AutoMapper;
using PsychologicalAssistance.Core.Data.DTOs;
using PsychologicalAssistance.Core.Data.Entities;
using System;

namespace PsychologicalAssistance.Core.Data.Helpers.AutoMapper
{
    public class ConsultingApplicationProfile : Profile
    {
        public ConsultingApplicationProfile()
        {
            CreateMap<ConsultingApplication, ConsultingApplicationDto>()
                .ForMember(dest => dest.ConvenientDay, opt => opt.MapFrom(src => src.ConvenientDay.ToShortDateString()));
            
            CreateMap<ConsultingApplicationDto, ConsultingApplication>()
                .ForMember(dest => dest.ConvenientDay, opt => opt.MapFrom(src => DateTime.Parse(src.ConvenientDay)));
        }
    }
}
