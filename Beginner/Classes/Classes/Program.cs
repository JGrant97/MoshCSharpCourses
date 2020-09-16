using System;
using Classes.Math;

namespace Classes
{

    class Program
    {
        static void Main(string[] args)
        {
            var john = new Person();
            john.firstName = "John";
            john.lastName = "Smith";
            john.Introduce();

            Calculator calculator = new Calculator();
            var result = calculator.add(1, 2);
            Console.WriteLine(result);
        }
    }
}
