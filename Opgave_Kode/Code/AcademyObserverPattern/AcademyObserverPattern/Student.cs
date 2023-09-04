using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyObserverPattern
{
    public class Student : Person , IObserver
    {
        private string _message;

        public string Message
        {
            get { return _message; }
            set { _message = value; }
        }
        public string Name { get; set; }

        public Student( string name) : base(name)
        {
            Name = name;
        }

        public void Update(object sender, EventArgs e)
        {
            Message = (sender as Academy).Message;
            Console.WriteLine("Studerende {0} modtog nyheden '{1}' fra Akademiet {2}", Name, Message, (sender as Academy).Name);
        }
    }

}
