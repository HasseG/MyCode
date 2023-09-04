using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
	public class ConcreteObserver : Observer
	{
		private ConcreteSubject subject;
		private int _state = 0;

		public int State
		{
			get { return _state; }
			set { _state = value; }
		}


		public ConcreteObserver(ConcreteSubject subject)
		{
			this.subject = subject;
		}

		public override void Update()
		{
			State = subject.State;

		}
	}
}
