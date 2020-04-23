using LeHieuCoreApp.Data.Entities;
using LeHieuCoreApp.Data.IRepositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeHieuCoreApp.Data.EF.Repositories
{
    public class BlogRepository : EFRepository<Blog, int>, IBlogRepository
    {
        public BlogRepository(AppDbContext context) : base(context)
        {
        }
    }
}
