using HybridNTierECommerce.DTO.CommonDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HybridNTierECommerce.DTO.DomainDTOs
{
    public class OrderDetailDTO : BaseDTO
    {
        public int OrderID { get; set; }
        public int ProductID { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }

        private string previousMessage = string.Empty;

        public override string GetDisplayName()
        {
            string message = $"Order with:{OrderID} id and Product with: {ProductID}";
            if (message == previousMessage) return string.Empty;
            previousMessage = message;
            return message;
        }
    }
}
