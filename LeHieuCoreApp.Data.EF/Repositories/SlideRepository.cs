using LeHieuCoreApp.Data.Entities;
using LeHieuCoreApp.Data.IRepositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeHieuCoreApp.Data.EF.Repositories
{
    public class SlideRepository : EFRepository<Slide, int>, ISlideRepository
    {
        public SlideRepository(AppDbContext dbContext) : base(dbContext)
        {
        }
    }
}
