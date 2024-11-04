using HybridNTıerECommerce.VIEWMODEL.ViewModels.AppUserVMs.PureVMs.RequestModels;
using HybridNTierECommerce.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HybridNTierECommerce.DTO.User;

namespace HybridNTierECommerce.IOC.MapperProfiles
{
    public class AppUserProfile : BaseProfile
    {
        public AppUserProfile()
        {
            CreateMap<AppUser, AppUserDTO>().ReverseMap();
            CreateMap<AppUser, UserRegisterRequestModelDTO>().ReverseMap();

            CreateMap<UserRegisterRequestModel, UserRegisterRequestModelDTO>().ReverseMap();
            CreateMap<UserSignInRequestModel, UserSignInRequestModelDTO>().ReverseMap();
        }
    }
}
