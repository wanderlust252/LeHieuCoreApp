using LeHieuCoreApp.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeHieuCoreApp.Data.Interfaces
{
    public interface ISwitchable
    {
        Status Status { set; get; }
    }
}
