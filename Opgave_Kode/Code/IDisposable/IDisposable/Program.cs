using System.IO;
using System.IO.Enumeration;

namespace IDisposable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fileText = "Dette er vildt meget tekst";
            string path = @"C:\Users\Bruger\file.txt";
            File.WriteAllText(path, fileText);
            StreamReader sr = new StreamReader(path);
            try
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }

            }
            finally
            {
              sr.Close();
            }
            Console.ReadLine();
        }
    }
}