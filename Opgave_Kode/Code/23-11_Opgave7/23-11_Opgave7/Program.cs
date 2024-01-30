using System.Runtime.ConstrainedExecution;

namespace _23_11_Opgave7
{
    internal class Program
    {
        //Precondition:	Parameteren number er større end nul 
        //Postcondition:	Der returneres True hvis number er et primtal, ellers returneres False
        //Eks.: IsPrime(29) returnerer True og IsPrime(8) returnerer False

        public static bool IsPrime(uint number)
        {
            bool result = false;

            if ((number == 0) || (number == 1) || (number % 2) == 0)
            {
                result = false;
            }
            else
            {
                for (int i = 2; i <= Math.Sqrt(number); i++)
                {
                    if ((number % i) == 0)
                    {
                        result = true;
                    }
                }
            }
            return result;
        }
        static void Main(string[] args)
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(IsPrime((uint)i) + $"{i}");
            }
            Console.ReadLine();
        }
    }
}