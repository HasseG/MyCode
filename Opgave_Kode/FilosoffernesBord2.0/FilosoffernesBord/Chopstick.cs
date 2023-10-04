using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilosoffernesBord
{
    public class Chopstick
    {
        public object IsLocked { get; set; } = new object();
        public string Name { get; set; }

        public Chopstick(string name)
        {
            Name = name;
        }

    }
}
