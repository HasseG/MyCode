using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class BookRepository
    {
        private List<Book> books = new List<Book>();

        public void AddBook(Book book)
        {
            books.Add(book);
        }

        public Book GetBook(string itemId)
        {
          Book reBook = null;

            foreach (Book book in books)
            {
                if (book.ItemId == itemId)
                    reBook = book;
            }
            return reBook;
        }

        public double GetTotalValue()
        {
            //hiv fat i utility hvis denne metode fejler
            
            double totalValue = 0;

            foreach (Book book in books)
            {
                totalValue = book.Price + totalValue;
            }
            return totalValue;
        }
        



    }
}
