namespace metoderOgKlasser
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            //Udskriver navn på program
            Console.WriteLine("LOMMEREGNER!");

            //Laver en instans af klassen Calculator
            Calculator calc = new Calculator();

            //Beder et input fra bruger (første tal)
            Console.WriteLine("Indtast første tal: ");
            int firNum = int.Parse(Console.ReadLine());

            //Beder et input fra bruger (andet tal)
            Console.WriteLine("Indtast andet tal: ");
            int secNum = int.Parse(Console.ReadLine());

            //Udskriver vores metode Add, fra klassen calculator, samt resultatet
            Console.WriteLine("Add: " + calc.Add(firNum,secNum));
          
            //Sættes ind, så programmet ikke lukker med det samme
            Console.Read();
        } 
    }
}