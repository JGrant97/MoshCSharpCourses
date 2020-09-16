using System;
using System.Collections.Generic;
using System.Text;

namespace WorkingWithTextE4_PascalCase_words
{
    class TextUtility
    {
        public static string Pascalcase(string text)
        {
            var wordList = new List<string>();
            var words = text.Split(' ');

            foreach (var word in words)
            {
                var newWord = word.Substring(0, 1).ToUpper() + word.Substring(1).ToLower();

                wordList.Add(newWord);

            }

            return string.Join("", wordList);
        }
    }
}
