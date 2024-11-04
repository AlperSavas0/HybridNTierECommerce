using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HybridNTierECommerce.ENTITIES.Models
{
    public class Order : BaseMoneySpec
    {
        public string ShippingAddress { get; set; }
        public string? Email { get; set; } //Email information of non-member user.
        public string? NameDesctiption { get; set; } //NameDescription of non-member user
        public int? AppUserID { get; set; } //if its null, user is not a member


        //Todo: AppUser iş akışı ödevi
        //Relational Properties
        public virtual AppUser AppUser { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }

    }
}
