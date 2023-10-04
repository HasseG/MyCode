using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Disaheim;

namespace Disaheim
{
    public class Amulet : Merchandise
    {
		private string _design;

		public  string Design
		{
			get { return _design; }
			set { _design = value; }
		}

		private Level _quality;

		public  Level Quality
		{
			get { return _quality; }
			set { _quality = value; }
		}

        private static double _lowQualityValue = 12.5;

        public static double LowQualityValue
        {
            get { return _lowQualityValue; }
            set { _lowQualityValue = value; }
        }

        private static double _mediumQualityValue = 20.0;

        public static double MediumQualityValue
        {
            get { return _mediumQualityValue; }
            set { _mediumQualityValue = value; }
        }

        private static double _highQualityValue = 27.5;

        public static double HighQualityValue
        {
            get { return _highQualityValue; }
            set { _highQualityValue = value; }
        }

        public Amulet(string itemId, Level quality, string design)
		{
			base.ItemId = itemId;
			this.Quality = quality;
			this.Design = design;
		}

		public Amulet(string itemId, Level quality) :
			this (itemId, quality, "")
		{}

		public Amulet(string itemId):
			this(itemId, Level.medium, "")
		{}


		public override string ToString()
		{
			return $"ItemId: {ItemId}, Quality: {Quality}, Design: {Design}";
        }

        public override double GetValue()
        {
			double result = 0;
			if (Quality == Level.low)
			{
				result = _lowQualityValue;
			}
			else if (Quality == Level.medium)
			{
				result = _mediumQualityValue;
			}
			else
			{
				result = _highQualityValue;
			}
			return result;

        }



	}
}

