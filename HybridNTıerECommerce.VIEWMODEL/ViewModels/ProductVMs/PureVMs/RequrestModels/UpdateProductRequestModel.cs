﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HybridNTıerECommerce.VIEWMODEL.ViewModels.ProductVMs.PureVMs.RequrestModels
{
    public class UpdateProductRequestModel
    {
        public int ID { get; set; }
        public string? ProductName { get; set; }
        public decimal? Price { get; set; }
        public int? UnitsInStock { get; set; }
        public int? CategoryID { get; set; }
        public string ImagePath { get; set; }
    }
}
