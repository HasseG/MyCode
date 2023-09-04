using System.Linq.Expressions;

namespace MyFirstProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Indtast Navn: ");
            string name = Console.ReadLine();

            Console.WriteLine("Navn: " + name);

            Console.Write("Indtast Alder: ");
                int age = Convert.ToInt32(Console.ReadLine());
                         
            Console.WriteLine("Alder: " + age);

            Console.WriteLine(name + " er " + age + " år gammel");

            Console.ReadLine();
        }
    }
}