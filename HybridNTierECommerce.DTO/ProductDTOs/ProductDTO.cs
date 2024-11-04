using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HybridNTierECommerce.DTO.CommonDTO;


namespace HybridNTierECommerce.DTO.ProductDTOs
{
    public class ProductDTO : BaseDTO
    {
        public int ID { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public int UnitsInStock { get; set; }
        public string CategoryName { get; set; }
        public int? CategoryID { get; set; }
        public string ImagePath { get; set; }
        public override string GetDisplayName()
        {
            return ProductName;
        }
    }
}
