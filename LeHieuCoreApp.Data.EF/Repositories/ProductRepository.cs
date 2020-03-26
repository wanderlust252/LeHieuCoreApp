using System;
using System.Collections.Generic;
using System.Text;
using LeHieuCoreApp.Data.Entities;
using LeHieuCoreApp.Data.IRepositories;

namespace LeHieuCoreApp.Data.EF.Repositories
{
    public class ProductRepository : EFRepository<Product, int>, IProductRepository
    {
        public ProductRepository(AppDbContext context) : base(context)
        {
        }
    }
}
