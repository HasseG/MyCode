namespace _08_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
               Console.WriteLine("Indtast højde på rektangel i cm:");
               int height = int.Parse(Console.ReadLine());

               Console.WriteLine("Indtast bredde på rektangel i cm:");
               int widht = int.Parse(Console.ReadLine());

               int result = height * widht;

               Console.WriteLine("Her er dit resultat i cm: " + result);
               */


            /*
            Console.WriteLine("Indtast x1 koordinat: ");
            double x1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Indtast y1 koordinat: ");
            double y1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Indtast x2 koordinat: ");
            double x2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Indtast y2 koordinat: ");
            double y2 = double.Parse(Console.ReadLine());

            double result = (y2 - y1) / (x2 - x1);

            Console.WriteLine("Din hældning for linjestykket er: " + result);
            */

           Console.WriteLine("Indtast tekst: ");
           string userInputString = Console.ReadLine();
           Console.WriteLine("Indtast bogstav: ");
           char userInputChar = char.Parse(Console.ReadLine());
           Console.WriteLine("Indtast substreng længde: ");
           //int userInputLenght = int.Parse(Console.ReadLine());


            int charInput = userInputString.IndexOf(userInputChar);
            //int stringLenght = userInput.Length;
           

            if (charInput == -1)
                Console.WriteLine("Karakteren er ikke blevet fundet");
            else
                Console.WriteLine("Positionen af char er: " + charInput);

            Console.ReadLine();
        }
    }
}