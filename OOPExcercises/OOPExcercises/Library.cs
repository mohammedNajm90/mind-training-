using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExcercises
{
    public class Library
    {
        private List<Book> books = new List<Book>();

        public void AddBook(Book book)
        {
            books.Add(book);
        }
        public void RemoveBook(string title)
        {
            books.RemoveAll(book => book.Title == title);
        }
        public void ShowBooks()
        {

            foreach (var b in books)
                Console.Write(b.Title + "  ");
            Console.WriteLine();
            
        }
    }
}
