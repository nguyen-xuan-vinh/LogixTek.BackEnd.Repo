﻿using AutoMapper;
using Coding.WebApi.Entities;

namespace Coding.WebApi.Models.Dtos
{
    public class UserLoginDto : Profile
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Username { get; set; }

        public string Token { get; set; }

        public UserLoginDto()
        {
            CreateMap<User, UserLoginDto>();
        }
    }
}
