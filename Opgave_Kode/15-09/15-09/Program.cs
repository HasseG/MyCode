using System;
using System.Reflection.Emit;
using System.Runtime.ExceptionServices;

namespace _15_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*   int kiet = 21;
               int hasse = 22;
               int johan = 24;
               int jacob = 26;
               int christian = 21;
               int mikkel = 24;
               int average = (kiet + hasse + johan + jacob + christian + mikkel) / 6;

                   Console.WriteLine("kiet er: " + kiet + " år gammel");
                   Console.WriteLine("kiet er: " + hasse + " år gammel");
                   Console.WriteLine("kiet er: " + johan + " år gammel");
                   Console.WriteLine("kiet er: " + jacob + " år gammel");
                   Console.WriteLine("kiet er: " + christian + " år gammel");
                   Console.WriteLine("kiet er: " + mikkel + " år gammel");

               Console.WriteLine("Vi er tilsammen: " + average + " år gamle!");
               */
            /*Console.ForegroundColor = ConsoleColor.Green;
            int[] team14 = new int[6] { 21, 22, 24, 26, 21, 24 };

            string[] names = new string[6] { "kiet", "hasse", "johan", "jacob", "christian", "mikkel" };
            int average = (team14[0] + team14[1] + team14[2] + team14[3] + team14[4] + team14[5]) / 6;

            for (int i = 0; i < team14.Length; i++)
            {
                //Console.WriteLine($" ==> {team14[i]}");
                Console.WriteLine(names[i] + " er " + team14[i] + " år gammel");
            }
            Console.WriteLine();
            Console.WriteLine("Vi er tilsammen: " + average + " år gamle!");
            */


            Console.WriteLine("Indtast array længde: ");
            int[] team14 = new int[int.Parse(Console.ReadLine())];
            int userInput = 0;
            for (int i = 0; i < team14.Length; i++)
            {
                Console.WriteLine("Indtast alder på person {0}", i);
                try
                {
                    team14[i] = int.Parse(Console.ReadLine());
                }catch (Exception e)
                {
                    Console.WriteLine("{0} dette er ikke en alder", team14[i]);
                }
            }
            Console.WriteLine("Her er dit array:");
            for (int i = 0; i < team14.Length; i++)
            {
                Console.Write(team14[i]);
                if (i<team14.Length - 1)
                {
                    Console.Write(",");
                    Console.Write("");
                }
            }

            Console.WriteLine("");
            Console.WriteLine("Indtast en af team 14 alder: ");
            // While true er okay her, da det ikke er et kompliceret loop. Der kan nemt komme en "grayzone"
            //Hvis brugeren vil ud af programmet, kan man her lave en mulighed for at lukke programmet.
            while (true)
            {
                string userInputString = Console.ReadLine();

                try
                {
                    userInput = int.Parse(userInputString);
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine("{0} dette er ikke en alder", userInputString);

                }
            }
            Console.WriteLine("________________");
            int count = 0;
            for (int i = 0; i < team14.Length; i++)
            {
                if (team14[i] == userInput)
                {
                    Console.WriteLine(team14[i]);
                    count ++;
                }
                
            }
            Console.WriteLine("Så mange medlemmer har denne alder: " + count);

            Console.ReadLine();
                
        }
    }
}