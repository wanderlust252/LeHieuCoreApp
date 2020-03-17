using System;
using System.Collections.Generic;
using System.Text;

namespace LeHieuCoreApp.Infrastruture.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        void Commit();
    }
}
