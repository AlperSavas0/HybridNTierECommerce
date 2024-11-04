using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HybridNTierECommerce.DTO.CommonDTO;


namespace HybridNTierECommerce.DTO.CategoryDTOs
{
    public class CategoryDTO : BaseDTO
    {
        public int ID { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        
        public override string GetDisplayName()
        {
            return CategoryName;
        }
    }
}
