using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            var books = new BookRepository().GetBooks();


            //Linq query operators
            var cheaperBooks = 
                from b in books
                where b.Price < 10
                orderby b.Title
                select b;

            //Linq extension methods
            var cheapestBooks = books
                                    .Where(b => b.Price < 10)
                                    .OrderBy(b => b.Title)
                                    .Select(b => b.Title);

            var single = books.First(b => b.Title == "C# Advanced topics");
            Console.WriteLine(single.Title + " " + single.Price +  "\n");

            var count = books.Count();
            Console.WriteLine(count);

            var max = books.Max(b => b.Price);
            Console.WriteLine(max);

            var min = books.Max(books => books.Price);
            Console.WriteLine(min);

            var totalPrices = books.Sum(b => b.Price);
            Console.WriteLine(totalPrices);

            foreach (var book in cheapestBooks)
            {
                // Console.WriteLine(book.Title + " " + book.Price);
                Console.WriteLine(book);
            }
        }
    }
}
