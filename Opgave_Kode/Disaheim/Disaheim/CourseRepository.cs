using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class CourseRepository
    {
        private List<Course> courses = new List<Course>();
        public void AddCourse(Course course)
        {
            courses.Add(course);
        }

        public Course GetCourse(string name)
        {
            Course reCourse = null;
            foreach (Course course in courses)
            {
                if (course.Name == name)
                    reCourse = course;
            }
            return reCourse;
        }
        public double GetTotalValue()
        {
            Utility utility = new Utility();
            double totalValue = 0;

            foreach (Course course in courses)
            {
                totalValue = totalValue + course.GetValue();
            }
            return totalValue;
        }
    }
}
