using Newtonsoft.Json.Serialization;
using System;

namespace Lambda_Expression
{
    class Program
    {
        static void Main(string[] args)
        {

            const int factor = 5;
            Func<int, int> multiplier = n => n * factor;
            var result =  multiplier(10);
            Console.WriteLine(result);

            Func<int, int> square = number => number*number;
            Console.WriteLine(square(5));

            var books = new BookRepository().GetBooks();
            var cheapBooks = books.FindAll(b => b.Price <10);

            int a = 1;
            int b = 2;

            Func add = (a,b) => a + b; 

            foreach (var book in cheapBooks)
            {
                Console.WriteLine(book.Title);
            }
        }
    }
}
