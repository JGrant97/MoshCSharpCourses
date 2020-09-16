using System;
using System.Collections.Generic;
using System.Text;

namespace SummarisingText
{
    public class StringUtility
    {
        public static string SummariseText(string text, int maxLength = 20)
        {
            if (text.Length < maxLength)
            {
                return text;
            }
            else
            {
                var words = text.Split(' ');
                var totalCharacters = 0;
                var wordList = new List<string>();

                foreach (var word in words)
                {
                    wordList.Add(word);

                    totalCharacters += word.Length + 1;
                    if (totalCharacters > maxLength)
                    {
                        break;
                    }
                }

                return String.Join(" ", wordList) + "...";
            }
        }
    }
}
