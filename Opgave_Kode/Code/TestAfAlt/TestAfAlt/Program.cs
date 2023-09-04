using System.Security.Cryptography.X509Certificates;

namespace UltimateDecider
{
    internal class program
    {
        static void Main(string[] args)
        {
            #region ToDoList
            /*Program til hurtigt at roll en terning 1, plat eller krone 2, spin hjulet (find på noget sjovt) 3, Felling lucky find noget spicey ASCII art 4.
             * 1 og 2 virker, samt check af bruger input.
             * 
             * færdiggør 3 og 4. kig evt. på 2 og sørg for den virker ordenligt.
             * Ryd op i flowet og lav tilbage knap.
             * Sørg for at man kan lukke programmet ordenligt evt. ved at taste 0. Program skal forsætte hvis man ikke gør
             * Efter hver brug af mulighed, sendes man tilbage til hoved menuen.
            */
            #endregion

            bool check = false;
            string mainMenu = "Please select one of the following options:\n 1. Roll a dice.\n 2. Flip a coin\n 3. Spin the wheel!\n 4. Felling Lucky!";
            Console.WriteLine(mainMenu);
            int userInput = 0;

            //Loops until user input is a number
            while (check == false)
            {
                try
                {
                    userInput = Int32.Parse(Console.ReadLine());
                    if (userInput == 0 || userInput >= 5)
                    {
                        check = false;
                    }
                    else 
                    {
                        check = true;
                    }
                }
                catch
                {
                    Console.WriteLine("Pick one of the menu items");
                    Console.WriteLine("\nPress enter to return");
                    Console.ReadLine();
                    check = false;
                    Console.Clear();
                    Console.WriteLine(mainMenu);
                }
            }
        
            switch (userInput)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("   _______\r\n  /\\ o o o\\\r\n /o \\ o o o\\_______\r\n<    >------>   o /|\r\n \\ o/  o   /_____/o|\r\n  \\/______/     |oo|\r\n        |   o   |o/\r\n        |_______|/");
                    Console.WriteLine("Please choose number of sides between 3-20.");
                   
                    int numberOfSides = Int32.Parse(Console.ReadLine());
                    DiceRoll diceRoll = new DiceRoll(numberOfSides);


                    Console.Clear();
                    Console.WriteLine("   _______\r\n  /\\ o o o\\\r\n /o \\ o o o\\_______\r\n<    >------>   o /|\r\n \\ o/  o   /_____/o|\r\n  \\/______/     |oo|\r\n        |   o   |o/\r\n        |_______|/");
                    Console.WriteLine($"Alright! Rolling a {diceRoll.diceSides} sided dice!");
                   
                    Thread.Sleep(600);
                    Console.Write(".");
                    Thread.Sleep(600);
                    Console.Write(".");
                    Thread.Sleep(600);
                    Console.Write(".");
                    Thread.Sleep(600);
                    Console.Write(".");
                    Thread.Sleep(600);
                    Console.Write(".");
                    Console.WriteLine("\n" + diceRoll.RollDice().ToString() + "!");
                    break;

                case 2:
                    Console.WriteLine("⠀⠀⠀⢀⡀⠀⠀⠀⠠⠤⠤⠤⠶⠶⠤⣤⣄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀\r\n⠀⠀⠀⠠⢊⣡⣶⣿⡷⠀⠀⠀⣀⣠⣤⣤⣤⣄⢹⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀\r\n⠀⠀⠀⠀⢿⠿⠟⠋⠀⠀⠀⣾⠉⠀⠀⠀⣀⣤⠞⢴⣆⠀⠀⠀⠀⠀⠀⠀⠀⠀\r\n⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠙⠛⠒⠚⠛⠉⠁⠀⠀⣿⠀⠀⠀⠀⠀⠀⠀⠀⠀\r\n⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠸⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀\r\n⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀\r\n⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣾⣷⣶⣶⡄⠀⢸⣿⣦⡀⠀⠀⠀⠀⠀⠀\r\n⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣀⣉⠉⠉⠀⠀⠀⠻⣿⣿⣷⡄⠀⠀⠀⠀\r\n⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠘⠛⠿⠿⢿⠆⢶⣦⣄⣿⣿⣿⣿⠀⠀⠀⠀\r\n⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣼⣿⣶⣶⣦⠀⢸⣿⣿⣿⣿⣿⣿⠀⠀⠀⠀\r\n⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢠⣬⣉⣉⣛⠀⢸⣿⣿⣿⣿⣿⣿⣄⠀⠀⠀\r\n⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣿⣿⠿⠟⠁⢸⣿⣿⣿⣿⣿⣿⣿⣷⡄⠀\r\n⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⠉⠛⠶⠾⠿⠿⢿⣿⣿⣿⣿⣿⣿⡇⠀\r\n⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠉⠉⠉⠉⠉⠉⠁⠀");
                    Console.WriteLine("Ready to flip a coin? Press enter to flip.");
                    Console.ReadLine();
                    CoinFlip.Flip();
                    break;
            }
            
        }

    }
}