using System;
using System.Collections.Generic;
using System.Linq;

namespace Count_Symbols
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine().ToCharArray();
            var symbolsCount = new SortedDictionary<char, int>();
            foreach (var charecter in input)
            {
                if (!symbolsCount.ContainsKey(charecter))
                {
                    symbolsCount[charecter] = 1;
                }
                else
                {
                    symbolsCount[charecter]++;
                }
            }
            foreach (var charecter in symbolsCount)
            {
                Console.WriteLine($"{charecter.Key}: {charecter.Value} time/s");
            }
        }
    }
}
