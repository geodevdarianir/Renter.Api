using AutoMapper;
using Entities.Models.Users;
using Entities.ViewModels.UserIdentityViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.ViewModels.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<RegisterModel, User>().ForMember(u => u.UserName, opt => opt.MapFrom(ur => ur.Email));
        }
    }
}
