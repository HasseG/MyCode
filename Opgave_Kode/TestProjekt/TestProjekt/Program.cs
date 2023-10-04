namespace TestProjekt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PhoneDetails phoneDetails = new PhoneDetails();
            phoneDetails.Size = "5";

            Phone phone = new Phone();  
            phone.Details = phoneDetails;
            Console.WriteLine(phone.Details.Size);
            Console.ReadKey();
        }
    }


    public class Phone
    {
        public string Model { get; set; }
        public PhoneDetails Details { get; set; }


    }
    public class PhoneDetails
    {
        public string Size { get; set; }


    }
}