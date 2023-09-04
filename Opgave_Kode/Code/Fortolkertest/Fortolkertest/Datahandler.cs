using CsvHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Formats.Asn1;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Fortolkertest
{
    public class Datahandler
    {
        //!!HUSK AT DENNE METODE VIRKER KUN PÅ HASSES COMPUTER!! !!ÆNDRER FILEPATH FOR AT FÅ DE TIL AT FUNGE!!
        //For each line read from the CSV file it calls our Interpreter FromCSV_M method and the returned objekt gets added to the list
        public List<Modul> ReadCSVForModules()
        {
            
            List<Modul> moduls = File.ReadAllLines("C:\\Users\\Bruger\\Desktop\\Studie\\Tipatek_Ekasmensprojekt\\Tipatek_eksempel_data.xlsx").Skip(1).Select(v => Interpreter.FromCSV_M(v)).ToList();
            moduls.ToList().ForEach(modul => { if (modul == null) moduls.Remove(modul); });

            return moduls;
        }
        //Overload method with costume filepath
        public List<Modul> ReadCSVForModules(string filePath)
        {
            List<Modul> moduls = File.ReadAllLines(filePath).Skip(1).Select(v => Interpreter.FromCSV_M(v)).ToList();
            moduls.ToList().ForEach(modul => { if (modul == null) moduls.Remove(modul); });

            return moduls;
        }
        //!!HUSK AT DENNE METODE VIRKER KUN PÅ HASSES COMPUTER!! !!ÆNDRER FILEPATH FOR AT FÅ DE TIL AT FUNGE!!
        //For each line read from the CSV file it calls our Interpreter FromCSV_C method and the returned objekt gets added to the list
        public List<Component> ReadCSVForComponents()
        {
            List<Component> components = File.ReadAllLines("C:\\Users\\Bruger\\Desktop\\Studie\\Tipatek_Ekasmensprojekt\\Tipatek_eksempel_data.xlsx").Skip(2).Select(v => Interpreter.FromCSV_C(v)).ToList();
            components.ToList().ForEach(component => { if (component == null) components.Remove(component); });

            return components;
        }
        //Overload method with costume filepath
        public List<Component> ReadCSVForComponents(string filePath)
        {
            List<Component> components = File.ReadAllLines(filePath).Skip(2).Select(v => Interpreter.FromCSV_C(v)).ToList();
            components.ToList().ForEach(component => { if (component == null) components.Remove(component); });

            return components;
        }
    }
}


