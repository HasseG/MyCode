using System.Security.Cryptography.X509Certificates;
using System.Threading;
namespace Threads
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread kietThread = new Thread (WriteKiet);
            kietThread.Start("Hello World (Method)");
            kietThread.Join();

            Thread johanThread = new Thread(x => {for (int i = 0; i < 4; i++) { Console.WriteLine(x); } });
            johanThread.Start("Hello World (Lambda)");
            johanThread.Join();

            Thread jacobThread = new Thread(delegate(object? x) { for (int i = 0; i < 4; i++) { Console.WriteLine(x); } });
            jacobThread.Start("Hello World (anonym)");
            jacobThread.Join();

            Console.ReadKey();
        }
        static void WriteKiet(object obj)
        {
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(obj);
            }
        }
    }
}