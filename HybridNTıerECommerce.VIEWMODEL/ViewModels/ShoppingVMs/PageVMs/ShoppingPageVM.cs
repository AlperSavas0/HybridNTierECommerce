using HybridNTıerECommerce.VIEWMODEL.ViewModels.CategoryVMs.PureVMs.ResponseModels;
using HybridNTıerECommerce.VIEWMODEL.ViewModels.ProductVMs.PureVMs.ResponseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using X.PagedList;

namespace HybridNTıerECommerce.VIEWMODEL.ViewModels.ShoppingVMs.PageVMs
{
    public class ShoppingPageVM
    {
        public List<CategoryResponseModel> Categories{ get; set; }
        public IPagedList<ProductResponseModel> Products{ get; set; }
    }
}
