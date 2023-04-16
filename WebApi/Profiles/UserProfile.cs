using AutoMapper;
using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Dtos;

namespace WebApi.Profiles
{
    public class UserProfile: Profile
    {

        public UserProfile()
        {
            // src => dest
            CreateMap<User, UserReadDto>();
            CreateMap<UserUpdateDto, User>();
            CreateMap<UserReadDto, User>();
            CreateMap<UserCreateDto, User>();

        }
    }
}
