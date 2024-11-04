using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HybridNTierECommerce.DTO.CommonDTO
{
    public abstract class BaseDTO
    {
        public string Status { get; set; }
        public abstract string GetDisplayName();
    }
}
