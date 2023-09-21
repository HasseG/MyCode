namespace DI_Opgave.Models
{
    public class Dummy : IMessage
    {
        public string PrintMessage(string message)
        {
            return message;
        }
    }
}
