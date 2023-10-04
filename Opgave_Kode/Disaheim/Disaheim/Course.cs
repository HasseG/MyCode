using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class Course : IValuable
    {
		private string _name;

		public string Name
		{
			get { return _name; }
			set { _name = value; }
		}

		private int _durationInMinutes;

		public int DurationInMinutes
		{
			get { return _durationInMinutes; }
			set { _durationInMinutes = value; }
		}

        private static double _courseHourValue = 875.0;

        public static double CourseHourValue
        {
            get { return _courseHourValue; }
            set { _courseHourValue = value; }
        }

        public Course(string name, int durationInMinuts)
		{
			this.Name = name;
			this.DurationInMinutes = durationInMinuts;
		}
		public Course(string name) :
			this(name, 0)
		{ }

		public double GetValue()
		{
			int amountHours = DurationInMinutes / 60;
            double result = CourseHourValue * amountHours;
            int amountRest = DurationInMinutes % 60;
            if (amountRest != 0)
            {
                result = result + CourseHourValue;
            }
            return result;
		}

        public override string ToString()
        {
            return $"Name: {Name}, Duration in Minutes: {DurationInMinutes}, Value: {GetValue()}";
        }

    }
}
