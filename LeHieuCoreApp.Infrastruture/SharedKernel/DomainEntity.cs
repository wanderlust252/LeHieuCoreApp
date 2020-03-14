using System;
using System.Collections.Generic;
using System.Text;

namespace LeHieuCoreApp.Infrastruture.SharedKernel
{
    public class DomainEntity<T>
    {
        public T Id { get; set; }
        public bool IsTransient()
        {
            // true nếu mới tạo ra. Đã có identity thì false
            return Id.Equals(default(T));
        }
    }
}
