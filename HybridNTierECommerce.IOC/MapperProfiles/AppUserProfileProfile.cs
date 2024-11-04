using HybridNTierECommerce.DTO.AppUserProfileDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HybridNTierECommerce.IOC.MapperProfiles
{
    public class AppUserProfileProfile:BaseProfile
    {
        public AppUserProfileProfile()
        {
            CreateMap<AppUserProfile, AppUserProfileDTO>().ReverseMap();
        }
    }
}
