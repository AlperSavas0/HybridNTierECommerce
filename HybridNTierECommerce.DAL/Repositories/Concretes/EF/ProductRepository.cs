using HybridNTierECommerce.DAL.ContextClasses;
using HybridNTierECommerce.DAL.Repositories.Abstracts;
using HybridNTierECommerce.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HybridNTierECommerce.DAL.Repositories.Concretes.EF
{
    public class ProductRepository : BaseRepository<Product>, IProductRepository
    {
        public ProductRepository(HybridECommerceContext db) : base(db)
        {

        }
    }
}
