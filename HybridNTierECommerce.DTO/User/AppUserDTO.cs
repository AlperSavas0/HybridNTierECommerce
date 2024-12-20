﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HybridNTierECommerce.DTO.CommonDTO;


namespace HybridNTierECommerce.DTO.User
{
    public class AppUserDTO : BaseDTO
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }

        public override string GetDisplayName()
        {
            return UserName;
        }
    }
}
