using System;
using System.Collections.Generic;

namespace Sets_of_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> firstSet = new HashSet<int>();
            HashSet<int> seckondSet = new HashSet<int>();
            HashSet<int> repeatingNumbers = new HashSet<int>();
            string[] input = Console.ReadLine().Split();
            int n = int.Parse(input[0]);
            int m = int.Parse(input[1]);
            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                firstSet.Add(number);
            }
            for (int i = 0; i < m; i++)
            {
                int number = int.Parse(Console.ReadLine());
                seckondSet.Add(number);
            }
            foreach (var number in firstSet)
            {
                if (seckondSet.Contains(number))
                {
                    repeatingNumbers.Add(number);
                }
            }
            Console.WriteLine(string.Join(" ",repeatingNumbers));
        }
    }
}
