using System;

namespace TypeConversion
{
    class TypeConversion
    {
        static void Main(string[] args)
        {
            // Converting byte to int
            byte b = 3; //max value of 255
            int i = b;
            Console.WriteLine("byte to int: " + b);

            //Converting int to byte
            int i2 = 1000;
            byte b2 = (byte) i2; //could result in data loss
            Console.WriteLine("int to byte + dataloss at large values: "+ b2);

            //Converting string to int
            var number = "1234";
            int i3 = Convert.ToInt32(number);
            Console.WriteLine("string to int: "+ i3);

            //Converting string to byte
            try
            {
                var number2 = "1234";
                byte b3 = Convert.ToByte(number2);
                Console.WriteLine("string to byte: " + b3);
            }
            catch (Exception)
            {
                Console.WriteLine("The number be converted to a byte");
            }

            //Converting string to bool
            try
            {
                var str = "true";
                bool bo = Convert.ToBoolean(str);
                Console.WriteLine("string to bool: " + bo);
            }
            catch (Exception)
            {
                Console.WriteLine("The string be converted to a bool");
            }
        }
    }
}
