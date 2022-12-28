using PredicateTask.Models;

namespace PredicateTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("AA WW", "CCC", 1000);
            Book book2 = new Book("BB PP", "BBB", 1100);
            Book book3 = new Book("CC TT", "CCC", 1200);
            Book book4 = new Book("AA", "DDD", 1300);
            Book book5 = new Book("AA", "EEE", 1400);
            Book book6 = new Book("AA", "FFF", 1500);

            Library library = new();

            library.AddBook(book1);
            library.AddBook(book2);
            library.AddBook(book3);
            library.AddBook(book4);
            library.AddBook(book5);
            library.AddBook(book6);

            foreach (var item in library.Books)
            {
                Console.WriteLine(item.Name);
            }
            Console.WriteLine(library.GetBook("A5").ToString());

            List<Book> foundBooks = library.FindAllBooks("CCC");

            Console.WriteLine("FindAll: ");
            foreach (var item in foundBooks)
            {
                Console.WriteLine(item.ToString());
            }

            library.RemoveAllBooks("CCC");

            Console.WriteLine("After removeall Method");
            foreach (var item in library.Books)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}