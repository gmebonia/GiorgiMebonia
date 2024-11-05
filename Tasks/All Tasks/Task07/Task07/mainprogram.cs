using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Task07.Libraryclass;

namespace Task07
{
    internal class program
    {
        static void Main(string[] args)
        {
            Library library = new Library(); // ბიბლიოთეკის პროგრამის ფუნქციონალი

            // როგორ უნდა დავამატოთ წიგნი (დამატების მეთოდი)

            library.AddBook(new Book("Animal Farm", "George Orwel", 1945));
            library.AddBook(new Book("Nineteen Eighty-Four", "George Orwell", 1949));
            library.AddBook(new Book("Mein Kampf", "Adolf Hitler", 1926));

            library.PrintBooks(); // ბიბლიოთეკაში არსებული წიგნების ნახვა

            Console.WriteLine("\nFinding books with 'Mein Kampf' in the title:"); // წიგნის მოძებნა
            var foundBooks = library.FindBook("Mein Kampf");
            foreach (var book in foundBooks)
            {
                Console.WriteLine(book);
            }

            library.RemoveBook("Animal Farm"); // ბიბლიოთეკაში არსებული წიგნის წაშლა

            
            Console.WriteLine("\nAfter removing 'Animal Farm':"); // ბიბლიოთეკიდან წაშლილი წიგნის ნახვა
            library.PrintBooks();

            
            Console.WriteLine($"\nNumber of books in the library: {library.Count}"); // ბიბლიოტეკაში წიგნების რაოდენობის ჩვენება
        }
    }
}
