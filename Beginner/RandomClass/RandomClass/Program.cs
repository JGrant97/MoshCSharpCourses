using System;

namespace RandomClass
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();

            const int length = 10;
            var buf = new char[length];
            for(var i = 0; i < length; i++)
            {
                buf[i] = (char)('a' + random.Next(0, 26));
            }

            var password = new string(buf);

            Console.WriteLine(password);
        }
    }
}
