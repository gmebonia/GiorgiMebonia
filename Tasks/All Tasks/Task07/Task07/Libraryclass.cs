using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task07
{
    internal class Libraryclass
    {
        public class Library
        {
            private List<Book> books = new List<Book>(); // წიგნების დასახელება

            public int Count => books.Count; // წიგნების რაოდენობა

            public void AddBook(Book book)  // წიგნის დამატება
            {
                books.Add(book);
                Console.WriteLine($"Added: {book.Title} by {book.Author}");
            }

            public void RemoveBook(string title) // წიგნის წაშლა
            {
                var bookToRemove = books.Find(b => b.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
                if (bookToRemove != null)
                {
                    books.Remove(bookToRemove);
                    Console.WriteLine($"Removed: {bookToRemove.Title} by {bookToRemove.Author}");
                }
                else
                {
                    Console.WriteLine("Book not found!");
                }
            }

            public List<Book> FindBook(string title) // წიგნის მოძებნა
            {
                return books.FindAll(b => b.Title.Contains(title, StringComparison.OrdinalIgnoreCase));
            }

            public void PrintBooks() // ბიბლიოთეკაში არსებული წიგნების დაბეჭდვა
            {
                if (books.Count == 0)
                {
                    Console.WriteLine("No books in the library.");
                    return;
                }

                Console.WriteLine("Books in the library:");
                foreach (var book in books)
                {
                    Console.WriteLine(book);
                }
            }
        }
    }
}
