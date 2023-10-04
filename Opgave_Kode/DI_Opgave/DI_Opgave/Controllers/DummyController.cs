using DI_Opgave.Models;

namespace DI_Opgave.Controllers
{
    public class DummyController
    {
        private readonly IMessage _iMessage;
        public DummyController(IMessage iMessage) 
        {
            _iMessage = iMessage;
        }
        
        public string Index()
        {
            return _iMessage.PrintMessage("Hello World!");
        }
    }
}
