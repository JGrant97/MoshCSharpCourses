using System;
using System.Linq;

namespace ArraysandListsE1_NameReverseArray
{
    class Program
    {
      
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name.");
            var names = Console.ReadLine();
            var reversed = ReverseName(names);
            Console.WriteLine("your name reversed is: " + reversed);
        }

        public static string ReverseName(string names)
        {
            string[] nameArray = names.Split(" ");
            string ans = "";

            for (int i = nameArray.Length - 1; i >= 0; i--)
            {
                ans += nameArray[i] + " ";
            }

            return ans.Substring(0, ans.Length - 1);
        }
    }
}
