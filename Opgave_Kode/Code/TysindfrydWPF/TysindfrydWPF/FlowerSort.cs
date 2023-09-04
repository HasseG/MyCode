using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;

namespace TysindfrydWPF
{
    public class FlowerSort
    {
        public string Name { get; set; }
        public string PictureName { get; set; }
        public int ProductionTime { get; set; }
        public int HalfLifeTime { get; set; }
        public int Size { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}, Picture Name: {PictureName}, Production Time: {ProductionTime}, Half Life Time: {HalfLifeTime}, Size: {Size}\n";
        }
    }
}
