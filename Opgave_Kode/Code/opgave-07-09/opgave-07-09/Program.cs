using System.Xml.Serialization;

namespace opgave_07_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.Write("Indtast dit navn: ");
            string name = Console.ReadLine();
            
            Console.Write("Indtast din alder: ");
            int age = int.Parse (Console.ReadLine());
            
            string tilstand = "";
            
            if (age >= 0 && age <= 12)
                tilstand = "barn";
            else if (age <= 19)
                tilstand = "en teenager";
            else if (age <= 25)
                tilstand = "en studerende";
            else if (age <= 67)
                tilstand = "i arbejde";
            else
                tilstand = "en pensionist";
            
            Console.WriteLine(name + " er " + age + " år gammel og er " + tilstand);
            
            Console.ReadLine();
            */
           
            int choice = 0;
            while (choice != 5)
                {
                    Console.WriteLine("Min fantastike menu: ");
                    Console.WriteLine();
                    Console.WriteLine("1. Gør dit");
                    Console.WriteLine("2. Gør dat");
                    Console.WriteLine("3. Gør noget");
                    Console.WriteLine("4. Få svaret på livet, universtet og alting");
                    Console.WriteLine("5. Luk program");
                    Console.WriteLine("(Tryk på menupunkt 1,2,3 eller 4)");

                    string messege = "";
                    choice = int.Parse(Console.ReadLine());

                switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Gør dit");
                            Console.WriteLine("Punkt {0} blev valgt: {1}", choice, messege);
                                break;
                        case 2:
                            Console.WriteLine("Gør dat");
                            Console.WriteLine("Punkt {0} blev valgt: {1}", choice, messege);
                                break;
                        case 3:
                            Console.WriteLine("Gør noget");
                            Console.WriteLine("Punkt {0} blev valgt: {1}", choice, messege);
                            
                                 break;
                        case 4:
                            Console.WriteLine("42");
                            Console.WriteLine("Punkt {0} blev valgt: {1}", choice, messege);
                                break;
                        case 5:
                            choice = 5;
                                break;
                        default:
                             Console.WriteLine("Det indtastede er ikke gyldigt: {0}", choice);
                                break;
                    }
                Thread.Sleep(1000);

                Console.Clear();
            }
            




        }
    }
}   