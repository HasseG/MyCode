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
            var message = _iMessage.PrintMessage() + " " + _iMessage.PrintMessage("Hello World!");
            return _iMessage.PrintMessage();
        }
    }
}
