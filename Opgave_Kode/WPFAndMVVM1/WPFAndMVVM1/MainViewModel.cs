using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Markup;
using WPFAndMVVM1;

namespace WPFAndMVVM1
{
    public class MainViewModel : INotifyPropertyChanged
    {
		private string _myLabelText = "Text not set yet";

		public string MyLabelText
		{
			get { return _myLabelText; }
			set { _myLabelText = value;
			OnPropertyChanged("MyLabelText");
			}
		}
			
        private string _myTextBox = "Text not set yet";
        public string MyTextBox
        {
            get { return _myTextBox; }
            set { _myTextBox = value; 
			OnPropertyChanged("MyTextBox");
			}
        }


		public event PropertyChangedEventHandler? PropertyChanged;
		protected void OnPropertyChanged(string propertyName)
		{
			PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
			if (propertyChanged != null)
			{
				propertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		public ICommand CommandUpdateLabel { get; } = new CommandUpdateLabel();
	}
}
