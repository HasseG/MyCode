using TotallySafeLib; 
namespace CustomExceptionHandling
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            try
            {
                int posValueNegativ = TotallySafe.GetValueAtPosition(-2);

                Console.WriteLine(posValueNegativ);
                Console.ReadLine();
            }
            catch (IndexOutOfRangeException MyEx)
            {
                Console.WriteLine(MyEx.Message);
            }
            catch (NegativeIndexOutOfRangeException MyEx)
            {
                Console.WriteLine(MyEx.Message);
            }
            try
            {
                double divideValue = TotallySafe.Divider(0);
                Console.WriteLine(divideValue);
            }
            catch (DivideByZeroException MyEx)
            {
                Console.WriteLine(MyEx.Message);
            }
            try
            {
                int toString = TotallySafe.StringToInt("sup sup");
                Console.WriteLine(toString);
            }
            catch (FormatException MyEx)
            {
                Console.WriteLine(MyEx.Message);
            }

           

            Console.ReadLine();

        }
    }
}