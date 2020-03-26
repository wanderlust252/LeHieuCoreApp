using LeHieuCoreApp.Data.Entities;
using LeHieuCoreApp.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeHieuCoreApp.Data.IRepositories
{
    public interface IProductCategoryRepository: IRepository<ProductCategory,int>
    {
        List<ProductCategory> GetByAlias(string alias);
    }
}
