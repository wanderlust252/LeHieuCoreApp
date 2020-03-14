using System;
using System.Collections.Generic;
using System.Text;

namespace LeHieuCoreApp.Data.Interfaces
{
    public interface IHasSoftDelete
    {
        bool IsDeleted { set; get; }
    }
}
