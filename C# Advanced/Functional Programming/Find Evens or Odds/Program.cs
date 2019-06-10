using System;
using System.Linq;
using System.Collections.Generic;
namespace Find_Evens_or_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string evenOrOdd = Console.ReadLine();
            List<int> evens = new List<int>();
            List<int> odds = new List<int>();

            Predicate<int> EvenOrOdd = number => number % 2 == 0;
            
            for (int i = numbers[0]; i <=numbers[1]; i++)
            {
                if (EvenOrOdd(i) == true && evenOrOdd=="even")
                {
                    evens.Add(i);
                }
                else if (EvenOrOdd(i) == false && evenOrOdd == "odd")
                {
                    odds.Add(i);

                }
            }
            if (evenOrOdd == "even")
            {
                Console.WriteLine(string.Join(" ",evens));
            }
            else
            {
                Console.WriteLine(string.Join(" ", odds));

            }
        }
    }
}
