using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DrinkStores.Models
{
    public class EFStoreResposity : IStoreRepository
    {
        private StoreDbContext context;
        public EFStoreResposity(StoreDbContext ctx)
        {
            context = ctx;
        }
        public IQueryable<Product> Products => context.Products;
    }
}
