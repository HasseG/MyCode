namespace DI_Opgave.Models
{
    public class Dummy : IMessage
    {
        public string PrintMessage(string message)
        {
            return message + " dummy";
        }
        public string PrintMessage()
        {
            return "this is dummy class";
        }
    }
}
