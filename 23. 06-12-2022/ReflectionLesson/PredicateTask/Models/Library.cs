using PredicateTask.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PredicateTask.Models
{
    public class Library : BaseModel
    {
        public List<Book> Books;

        public Library()
        {
            Books = new List<Book>();
        }

        public void AddBook(Book book)
        {
            if (book != null) Books.Add(book);
            else throw new NullReferenceException("Book can't be null!");
        }

        public Book GetBook(string value)
        {
            Book wantedBook = Books.Find(book => book.Name.Contains(value) || book.AuthorName.Contains(value) || book.PageCount.ToString() == value || book.Price.ToString() == value || book.Code.Contains(value));

            if (wantedBook != null) return wantedBook;
            else throw new NullReferenceException("Book not found");
        }

        public List<Book> FindAllBooks(string value)
        {
            return Books.FindAll(book => book.Name.Contains(value) || book.AuthorName.Contains(value) || book.PageCount.ToString() == value || book.Price.ToString() == value || book.Code.Contains(value));
        }

        public void RemoveAllBooks(string value)
        {
             Books.RemoveAll(book => book.Name.Contains(value) || book.AuthorName.Contains(value) || book.PageCount.ToString() == value || book.Price.ToString() == value || book.Code.Contains(value));
        }

    }
}
