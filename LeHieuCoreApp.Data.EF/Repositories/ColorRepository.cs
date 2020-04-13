using LeHieuCoreApp.Data.Entities;
using LeHieuCoreApp.Data.IRepositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeHieuCoreApp.Data.EF.Repositories
{
    public class ColorRepository : EFRepository<Color, int>, IColorRepository
    {
        public ColorRepository(AppDbContext context) : base(context)
        {
        }
    }
}
