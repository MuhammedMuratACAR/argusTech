using argusTech.DTO.DTOs.UserDtos;
using argusTech.Entities.Concrete;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace argusTechWeb.Mapping.AutoMapperProfile
{
    public class MapProfile:Profile
    {
        public MapProfile()
        {
            CreateMap<UserListDto, User>();
            CreateMap<User, UserListDto>();

            CreateMap<UserAddDto, User>();
            CreateMap<User, UserAddDto>();
        }
    }
}
