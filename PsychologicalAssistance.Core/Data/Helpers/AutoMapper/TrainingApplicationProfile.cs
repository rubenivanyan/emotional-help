using AutoMapper;
using PsychologicalAssistance.Core.Data.DTOs;
using PsychologicalAssistance.Core.Data.Entities;

namespace PsychologicalAssistance.Core.Data.Helpers.AutoMapper
{
    public class TrainingApplicationProfile : Profile
    {
        public TrainingApplicationProfile()
        {
            CreateMap<TrainingApplication, TrainingApplicationDto>().ReverseMap();
            CreateMap<TrainingApplication, FullTrainingApplicationDto>()
                .ForMember(i => i.Title, d => d.MapFrom(i => i.Training.Title));
        }
    }
}
