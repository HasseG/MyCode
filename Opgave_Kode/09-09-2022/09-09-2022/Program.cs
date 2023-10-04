namespace _09_09_2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* string str = "abcdefg";
             char ch2 = str[1];
             char ch4 = str[3];
             char ch6 = str[5];

             Console.WriteLine("{0},{1},{2}", ch2, ch4, ch6);
            */

            /* Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Indtast en tækstreng: ");
             string userInput = Console.ReadLine();
             int stringLenght = userInput.Length;
             int i = 0;
             

            while (i < stringLenght)
            {
                if (Char.IsDigit(userInput[i]))
                {

                    Console.WriteLine("{0}:{1} (Ciffer)", i, userInput[i]);
                }
                else if (userInput[i] == '+' || '-' == userInput[i])
                {
                    Console.WriteLine("{0}:{1} (Operator)", i, userInput[i]);
                }
                else
                    Console.WriteLine("{0}:{1} (Ukendt)", i, userInput[i]);
                i++;
            }
            */

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Indtast et regnestykke: ");
            string userInput = Console.ReadLine();
            int stringLenght = userInput.Length;
            int i = 0;


            while (i < stringLenght)
            {
                if (Char.IsDigit(userInput[i]))
                {

                    Console.WriteLine("{0}:{1} (Ciffer)", i, userInput[i]);
                }
                else if (userInput[i] == '+' || '-' == userInput[i])
                {
                    Console.WriteLine("{0}:{1} (Operator)", i, userInput[i]);
                }
                else
                    Console.WriteLine("{0}:{1} (Ukendt)", i, userInput[i]);
                i++;
            }
            Console.ReadLine();





            /*  Console.WriteLine("Indtast første heltal: ");
              int a = int.Parse(Console.ReadLine());

              Console.WriteLine("Indtast andet heltal: ");
              int b = int.Parse(Console.ReadLine());

              int calculator = a / b;
              int modulusOfA_B = a % b;

              Console.WriteLine("Heltalskvotienten er: " +calculator);
              Console.WriteLine("Modulus er: "+modulusOfA_B);
            */


        }
    }
}