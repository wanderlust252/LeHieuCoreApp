using LeHieuCoreApp.Data.Entities;
using LeHieuCoreApp.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeHieuCoreApp.Data.IRepositories
{
    public interface ISystemConfigRepository : IRepository<SystemConfig, string>
    {
    }
}
