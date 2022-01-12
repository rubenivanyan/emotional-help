using AutoMapper;
using PsychologicalAssistance.Core.Data.DTOs;
using PsychologicalAssistance.Core.Data.Entities;
using System;

namespace PsychologicalAssistance.Core.Data.Helpers.AutoMapper
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<UserRegistrationDto, User>()
                .ForMember(user => user.UserName, opt => opt.MapFrom(x => x.Name))
                .ForMember(user => user.UserSurname, opt => opt.MapFrom(x => x.Surname))
                .ForMember(user => user.BirthDate, opt => opt.MapFrom(x => DateTime.Parse(x.BirthDate)));

            CreateMap<User, UserDto>()
                .ForMember(user => user.FullName, opt => opt.MapFrom(src => src.UserName + " " + src.UserSurname))
                .ForMember(user => user.BirthDate, opt => opt.MapFrom(src => src.BirthDate.ToShortDateString()));

            CreateMap<User, UserModifyDto>()
                .ForMember(dest => dest.BirthDate, opt => opt.MapFrom(src => src.BirthDate.ToShortDateString()));
        }
    }
}
