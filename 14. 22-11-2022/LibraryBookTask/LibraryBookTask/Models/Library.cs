using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace LibraryBookTask.Models
{
    internal class Library
    {
        //public Book[] Books = new Book[0];
        public Book[] Books;  //{book1,book2} 2 -> {book1,book2,book3} 3

        public Library()
        {
            Books = Array.Empty<Book>();
        }

        public void AddBook(Book book)
        {
            Array.Resize(ref Books, Books.Length+1);
            Books[Books.Length - 1] = book;
        }

        public void AddBook(ref Book[] booksArray,Book book)
        {
            Array.Resize(ref booksArray, booksArray.Length + 1);
            booksArray[booksArray.Length - 1] = book;
        }

        public Book[] GetFilteredBooks(string genre)
        {
            Book[] filteredBooks = Array.Empty<Book>();

            for (int i = 0; i < Books.Length; i++)
            {
                if (Books[i].Genre.ToLower() == genre.ToLower())
                {
                    AddBook(ref filteredBooks, Books[i]);
                }
            }
            return filteredBooks;
        }


        public Book[] GetFilteredBooks(double minPrice, double maxPrice)
        {
            Book[] filteredBooks = Array.Empty<Book>();

            for (int i = 0; i < Books.Length; i++)
            {
                if (Books[i].Price >= minPrice && Books[i].Price <= maxPrice)
                {
                    AddBook(ref filteredBooks, Books[i]);
                }
            }
            return filteredBooks;
        }
    }
}
