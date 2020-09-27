using System;
using System.Collections.Generic;
using System.Text;

namespace LINQ
{
    class BookRepository
    {
        public IEnumerable<Book> GetBooks()
        {
            return new List<Book>
            {
                new Book() {Title = "ADO.Net step by step", Price = 5},
                new Book() {Title = "ASP.Net MVC", Price = 9.99f},
                new Book() {Title = "ASP.Net Web API", Price = 12},
                new Book() {Title = "C# Advanced topics", Price = 7},
                new Book() {Title = "C# Advanced topics", Price = 9}

            };
        }
    }
}
