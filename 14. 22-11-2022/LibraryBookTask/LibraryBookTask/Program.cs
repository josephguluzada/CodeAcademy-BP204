using LibraryBookTask.Models;

namespace LibraryBookTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book();
            book1.Name = "Cinayet ve Ceza";
            book1.Genre = "Dram";
            book1.Price = 50;

            Book book2 = new Book();
            book2.Name = "Cinayet ve Ceza 2";
            book2.Genre = "Comedy";
            book2.Price = 40;
            Book book3 = new Book();
            book3.Name = "Cinayet ve Ceza 3";
            book3.Genre = "Action";
            book3.Price = 30;
            Book book4 = new Book();
            book4.Name = "Cinayet ve Ceza 4";
            book4.Genre = "Dram";
            book4.Price = 20;

            Library library = new Library();
            library.AddBook(book1);
            library.AddBook(book2);
            library.AddBook(book3);
            library.AddBook(book4);

            foreach (Book book in library.GetFilteredBooks("dram"))
            {
                Console.WriteLine($"Book name: {book.Name} - Genre: {book.Genre}");
            }
            Console.WriteLine("==============================");
            foreach (Book book in library.GetFilteredBooks(23,60))
            {
                Console.WriteLine($"Book name: {book.Name} - Genre: {book.Genre}");
            }
        }
    }
}