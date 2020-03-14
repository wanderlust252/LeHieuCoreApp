using System;
using System.Collections.Generic;
using System.Text;

namespace LeHieuCoreApp.Data.Interfaces
{
    public interface IHasOwner<T>
    {
        T OwnerId { get; set; }
    }
}
