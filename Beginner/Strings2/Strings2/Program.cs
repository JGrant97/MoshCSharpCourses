using System;

namespace Strings2
{
    class Program
    {
        static void Main(string[] args)
        {
            var fullname = "Jack Grant ";
            Console.WriteLine("Trim: '{0}'", fullname.Trim());
            Console.WriteLine("ToUpper: '{0}'", fullname.Trim().ToUpper());
            Console.WriteLine("ToLower: '{0}'", fullname.Trim().ToLower());

            var index = fullname.IndexOf(' ');
            var firstName = fullname.Substring(0, index);
            var lastName = fullname.Substring(index + 1);
            Console.WriteLine("\nFirstName: " + firstName);
            Console.WriteLine("LastName: " + lastName);

            var names = fullname.Split(' ');
            Console.WriteLine("\nFirstName: " + names[0]);
            Console.WriteLine("LastName: " + names[1]);
       
            Console.WriteLine("Replace: " + fullname.Replace("Jack", "Lee"));

            if(String.IsNullOrWhiteSpace(" "))
            {
                Console.WriteLine("Invalid");
            }

            var input = "25";
            int num = Convert.ToInt32(input);
            Console.WriteLine("String to number: " + num);

            float price = 29.95f;
            var strPric = price.ToString("C");
            Console.WriteLine("Number to string in currency: " + strPric);
        }
    }
}
