using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class Controller
    {
        //private List<Book> _books;

        //public List<Book> Books
        //{
        //    get { return _books; }
        //    set { _books = value; }
        //}
        //private List<Amulet> _amulets;

        //public List<Amulet> Amulets
        //{
        //    get { return _amulets; }
        //    set { _amulets = value; }
        //}

        //private List<Course> _courses;
        //public List<Course> Courses
        //{
        //    get { return _courses; }
        //    set { _courses = value; }
        //}

        private ValuableRepository _valuableRepo;

        public ValuableRepository ValuableRepo
        {
            get { return _valuableRepo; }
            set { _valuableRepo = value; }
        }


        public Controller()
        {
           _valuableRepo = new ValuableRepository();
        }

        public void AddToList(IValuable valuable)
        {
            _valuableRepo.AddValuable(valuable);
        }

        //public void AddToList(Book book)
        //{
        //    _books.Add(book);
        //}

        //public void AddToList(Amulet amulet)
        //{
        //    _amulets.Add(amulet);
        //}

        //public void AddToList(Course course)
        //{
        //    _courses.Add(course);
        //}








    }
}
