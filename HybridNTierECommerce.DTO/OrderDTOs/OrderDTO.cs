using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HybridNTierECommerce.DTO.CommonDTO;


namespace HybridNTierECommerce.DTO.OrderDTOs
{
    public class OrderDTO : BaseDTO
    {
        public int ID { get; set; }
        public string ShippingAddress { get; set; }
        public decimal Price { get; set; }
        public string? Email { get; set; } // Email address for non-member user
        public string? NameDescription { get; set; }//Name for non-member user
        public int? AppUserID { get; set; } //if it's null, user is not a member
        public override string GetDisplayName()
        {
            return $"Order with ID={ID}";
        }
    }
}
