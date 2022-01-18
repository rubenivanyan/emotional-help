﻿using AutoMapper;
using PsychologicalAssistance.Core.Data.DTOs;
using PsychologicalAssistance.Core.Data.Entities;
using System;

namespace PsychologicalAssistance.Core.Data.Helpers.AutoMapper
{
    public class BookProfile : Profile
    {
        public BookProfile()
        {
            CreateMap<Book, BookDto>()
                .ForMember(dest => dest.Genre, opt => opt.MapFrom(src => Enum.GetName(src.Genre)))
                .ReverseMap();
        }
    }
}
