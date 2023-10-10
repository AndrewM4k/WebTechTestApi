﻿using AutoMapper;
using WebApplication1.Dtos;
using WebApplication1.Models;

namespace ApiWithEF.Common
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<AddUserDto, User>();
            CreateMap<User, AddUserDto>();
            CreateMap<GetUserDto, User>();
            CreateMap<User, GetUserDto>();
        }    
    }
}