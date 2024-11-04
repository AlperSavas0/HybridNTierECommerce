using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HybridNTıerECommerce.VIEWMODEL.ViewModels.ProductVMs.PureVMs.ResponseModels
{
    public class ProductResponseModel
    {
        public int ID { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public string CategoryName { get; set; }
        public int UnitsInStock { get; set; }
        public string ImagePath { get; set; }
        public string Status { get; set; }
    }
}
