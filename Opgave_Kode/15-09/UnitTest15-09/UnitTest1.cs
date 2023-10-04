namespace UnitTest15_09
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Console.WriteLine("Indtast array længde: ");
            int[] team14 = new int[int.Parse(Console.ReadLine())];

            for (int i = 0; i < team14.Length; i++)
            {
                Console.WriteLine("Indtast alder på person {0}", i);
                try
                {
                    team14[i] = int.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine("{0} dette er ikke en alder", team14[i]);
                }
            }
            Console.WriteLine("Her er dit array:");
            for (int i = 0; i < team14.Length; i++)
            {
                Console.Write(team14[i]);
                if (i < team14.Length - 1)
                {
                    Console.Write(",");
                    Console.Write("");
                }
            }


            Console.WriteLine("");
            Console.WriteLine("Indtast en af team 14 alder: ");
            int userInput = int.Parse(Console.ReadLine());


            for (int i = 0; i < team14.Length; i++)
            {
                if (team14[i] == userInput)
                {
                    Console.WriteLine(team14[i]);
                    break;
                }

            }
            Console.ReadLine();
        }
    }
}