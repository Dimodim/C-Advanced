using System;
using System.IO;

namespace Line_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {

            var test = File.ReadAllLines("text.txt");
            int lineCounter = 1;
            foreach (var curentLine in test)
            {
                int charCount = CharecterCount(curentLine);
                int punctuationCount = PunctuationCount(curentLine);
                Console.WriteLine($"Line{lineCounter}: {curentLine} ({charCount})({punctuationCount})");
            }
        }

        private static int CharecterCount(string curentLine)
        {
            int count = 0;
            foreach (char item in curentLine)
            {
                if (Char.IsLetterOrDigit(item))
                {
                    count++;
                }
            }
            return count;
        }

        private static int PunctuationCount(string curentLine)
        {
            int count = 0;
            foreach (var item in curentLine)
            {
                if(item == '-' || item == '\'' || item == '.' || item == '!' || item == '?' || item == ',')
                {
                    count++;
                }
                    
            }

            return count;
        }
    }
}
