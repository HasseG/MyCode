
using System.Drawing;

namespace TotallySafeLib
{
    public class TotallySafe
    {
        public static double Divider(int number)
        {
                return 7 / number;
        }
        public static int StringToInt(string stringToConvert)
        {
            return int.Parse(stringToConvert);
        }
        public static int GetValueAtPosition(int positionInArray)
        {
            if (positionInArray < 0)
            {
                throw new NegativeIndexOutOfRangeException("Index position is a negativ number");
            }
            int[] intArray = { 1, 2, 3, 4, 5 };
            return intArray[positionInArray];
        }
    }

    public class NegativeIndexOutOfRangeException : Exception
    {
        public NegativeIndexOutOfRangeException()
        {
        }

        public NegativeIndexOutOfRangeException(string message)
            : base (message)
        {
        }

        public NegativeIndexOutOfRangeException(string message, Exception inner)
            : base (message, inner)
        {
        }


    }
}
