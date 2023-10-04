using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyObserverPattern
{
    public delegate void Eventhandler (object seender, EventArgs e); 
    public class Academy : Organization , INotifyPropertyChanged 
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        private string _message;

        public string Message
        {
            get { return _message; }
            set { _message = value; OnMessageChanged(); }
        }

        public Academy(string name, string address) : base(name)
        {
            name = Name;
            address = Address;
        }

        public void OnMessageChanged()
        {
            PropertyChanged(this, null);
        }
    }
}
