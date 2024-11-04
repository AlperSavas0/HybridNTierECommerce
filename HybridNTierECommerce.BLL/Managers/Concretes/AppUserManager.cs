using AutoMapper;
using HybridNTierECommerce.BLL.Managers.Abstracts;
using HybridNTierECommerce.DAL.Repositories.Abstracts;
using HybridNTierECommerce.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HybridNTierECommerce.DTO.User;

namespace HybridNTierECommerce.BLL.Managers.Concretes
{
    public class AppUserManager : BaseManager<AppUser, AppUserDTO>, IAppUserManager
    {
        readonly IAppUserRepository _userRep;

        public AppUserManager(IAppUserRepository userRep, IMapper mapper) : base(userRep, mapper)
        {
            _userRep = userRep;
        }
    }
}
