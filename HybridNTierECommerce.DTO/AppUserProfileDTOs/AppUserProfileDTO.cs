using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HybridNTierECommerce.DTO.CommonDTO;


namespace HybridNTierECommerce.DTO.AppUserProfileDTOs
{
    public class AppUserProfileDTO : BaseDTO
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public override string GetDisplayName()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
