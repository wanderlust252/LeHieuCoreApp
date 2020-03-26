using System;
using System.Collections.Generic;
using System.Text;

namespace LeHieuCoreApp.Infrastructure.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        void Commit();
    }
}
