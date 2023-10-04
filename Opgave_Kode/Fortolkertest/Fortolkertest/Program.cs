using System.Diagnostics;

namespace Fortolkertest
{
    public class Program
    {
        static void Main(string[] args)
        {
            Datahandler dh = new Datahandler();

            dh.ReadCSVForModules().ForEach(x => { Console.WriteLine(x); });
            Console.WriteLine("----");
            dh.ReadCSVForComponents().ForEach(x => { Console.WriteLine(x); });

            Console.ReadLine();
        }
    }}
