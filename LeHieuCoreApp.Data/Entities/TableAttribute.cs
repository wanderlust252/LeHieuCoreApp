using System;

namespace LeHieuCoreApp.Data.Entities
{
    internal class TableAttribute : Attribute
    {
        private string v;

        public TableAttribute(string v)
        {
            this.v = v;
        }
    }
}