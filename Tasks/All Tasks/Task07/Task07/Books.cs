using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task07
{
    internal class Books;

    public class Book // წიგნის კლასის შექმნა
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }
        public int Page { get; set; }

        public Book(string title, string author, int year)  // კონსტრუქტორის შექმნა
        {
            Title = title;
            Author = author;
            Year = year;
            Page = Page;

        }

        public override string ToString()  // წიგნის შესახებ ზოგადი ინფო
        {
            return $"Title: {Title}, Author: {Author}, Year: {Year}, Page: {Page}";
        }
    }
}
