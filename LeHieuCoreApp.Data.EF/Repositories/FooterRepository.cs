using LeHieuCoreApp.Data.Entities;
using LeHieuCoreApp.Data.IRepositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeHieuCoreApp.Data.EF.Repositories
{
    public class FooterRepository : EFRepository<Footer, string>, IFooterRepository
    {
        public FooterRepository(AppDbContext dbContext) : base(dbContext)
        {
        }
    }
}
