using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fortolkertest
{
    public class Interpreter
    {
        //Takes a string and splits it up on ";". Then it checks the lenght of the array to determin how the objects property is set.
        public static Component FromCSV_C(string csvLine)
        {
            string[] lines = csvLine.Split(";", StringSplitOptions.RemoveEmptyEntries);
            Component comp = new Component();
            if (lines.Length == 5)
            {
                comp.Identifier = lines[0] + lines[1] + lines[2] + lines[3];
                comp.Name = lines[4];
                return comp;
            }
            else if (lines.Length <= 4)
            {
                comp.Identifier = lines[0] + lines[1] + lines[2];
                comp.Name = lines[3];
                return comp;
            }
            else
            {
                return null;
            }
        }
        //Takes a string and splits it up on ";". Then it checks the lenght of the array to determin how the objects property is set.
        public static Modul FromCSV_M(string csvLine)
        {
            string[] lines = csvLine.Split(";", StringSplitOptions.RemoveEmptyEntries);
            if (lines.Length == 3)
            {
                Modul modul = new Modul();
                modul.ModuleCode = lines[0] + lines[1];
                modul.Name = lines[2];
                return modul;
            }
            else
            {
                return null;
            }
        }

    }
}
