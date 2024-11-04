using AutoMapper;
using HybridNTierECommerce.BLL.Managers.Abstracts;
using HybridNTierECommerce.DAL.Repositories.Abstracts;
using HybridNTierECommerce.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HybridNTierECommerce.DTO.AppUserProfileDTOs;

namespace HybridNTierECommerce.BLL.Managers.Concretes
{
    public class AppUserProfileManager : BaseManager<AppUserProfile, AppUserProfileDTO>, IAppUserProfileManager
    {
        IAppUserProfileRepository _profileRep;

        public AppUserProfileManager(IAppUserProfileRepository profileRep, IMapper mapper) : base(profileRep, mapper)
        {
            _profileRep = profileRep;
        }
    }
}
