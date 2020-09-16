using System;
using System.Collections.Generic;
using System.Linq;

namespace SummarisingText
{
    class Program
    {
        static void Main(string[] args)
        {
            var sentence = "This is going to be a really really really really really really long text.";
            var summary = StringUtility.SummariseText(sentence, 25);
            Console.WriteLine(summary); 
        }
    }
}
