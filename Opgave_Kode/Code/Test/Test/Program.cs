namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Phone phone = new Phone();
            phone.Number = 23142142;

            PhoneDetials phoneDetials = new PhoneDetials();
            phoneDetials.Size = 6;
            phoneDetials.Model = "iPhone 13";

            phone.Detials = phoneDetials;

            Console.WriteLine(phone.Number);
            Console.WriteLine(phone.Detials.Model);
            Console.WriteLine(phone.Detials.Size);

            Console.ReadKey();
        }
    }
    public class Phone
    {
        public int Number { get; set; }
        public PhoneDetials Detials { get; set; }
    }
    public class PhoneDetials
    {
        public int Size { get; set; }
        public string Model { get; set; }

    }
}