using LeHieuCoreApp.Data.Entities;
using LeHieuCoreApp.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeHieuCoreApp.Data.IRepositories
{
    public interface IBlogRepository : IRepository<Blog, int>
    {
    }
}
