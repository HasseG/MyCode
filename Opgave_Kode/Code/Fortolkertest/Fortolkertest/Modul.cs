using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fortolkertest
{
    public class Modul
    {
        public string Name { get; set; }

        public string ModuleCode { get; set; }

        public override string ToString()
        {
            return $"Module: {ModuleCode} {Name}";
        }
    }
}
