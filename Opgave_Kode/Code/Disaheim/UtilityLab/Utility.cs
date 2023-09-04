//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using Disaheim;

//namespace UtilityLab

//{
//    public class Utility
//    {
//        public double GetValueOfBook(Book book)
//        {
//            return book.Price;
//        }

//        public double GetValueOfAmulet(Course amulet)
//        {
//            if (amulet.Quality == Level.low)
//            {
//                return 12.5;
//            }
//            else if (amulet.Quality == Level.medium)
//            {
//                return 20.0;
//            }
//            else
//                return 27.5;
//        }

//        public double GetValueOfCourse(Course course)
//        {
//            int amountHours = course.DurationInMinutes / 60;
//            double result = 875.0 * amountHours;
//            int amountRest = course.DurationInMinutes % 60;
//            if (amountRest != 0)
//            {
//                result = result + 875.0;
//            }
//            return result;

//        }
//    }
//}
