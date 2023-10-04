using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fortolkertest
{
    public class Component
    {

        public string Name { get; set; }
        public string Identifier { get; set; }

        public override string ToString()
        {
            return $"Component: {Identifier} {Name}";
        }

    }
}
