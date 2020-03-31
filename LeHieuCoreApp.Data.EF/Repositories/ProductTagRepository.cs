using LeHieuCoreApp.Data.Entities;
using LeHieuCoreApp.Data.IRepositories;
using System;
using System.Collections.Generic;
using System.Text; 

namespace LeHieuCoreApp.Data.EF.Repositories
{ 
        public class ProductTagRepository : EFRepository<ProductTag, int>, IProductTagRepository
        {
            public ProductTagRepository(AppDbContext context) : base(context)
            {
            }
        } 
}
