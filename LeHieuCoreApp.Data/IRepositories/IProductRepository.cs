using System;
using System.Collections.Generic;
using System.Text;
using LeHieuCoreApp.Data.Entities;
using LeHieuCoreApp.Infrastructure.Interfaces;

namespace LeHieuCoreApp.Data.IRepositories
{
    public interface IProductRepository : IRepository<Product,int>
    {
    }
}
