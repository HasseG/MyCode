namespace DI_Opgave.Models
{
    public class Dummy2 : IMessage

    {
        public string PrintMessage(string message)
        {
            return message + " dummy2";
        }
        public string PrintMessage()
        {
            return "This is dummy2 class";
        }

    }
}
