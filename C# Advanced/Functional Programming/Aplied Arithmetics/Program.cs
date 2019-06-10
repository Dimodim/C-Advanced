using System;
using System.Collections.Generic;
using System.Linq;

namespace Aplied_Arithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Func<int[], int[]> add = collection => collection.Select(number => number + 1).ToArray();
            Func<int[], int[]> multyply = collection => collection.Select(number => number *2).ToArray();
            Func<int[], int[]> subtract = collection => collection.Select(number => number -1).ToArray();
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "end")
                {
                    break;
                }
                else if (command == "add")
                {
                    input = add(input);
                }
                else if (command == "multiply")
                {
                    input = multyply(input);
                }
                else if (command == "subtract")
                {
                    input = subtract(input);
                }
                else if (command == "print")
                {
                    Console.WriteLine(string.Join(" ",input));
                }
            }

        }
        //public static IEnumerable<int> ForEach(IEnumerable<int> collection, Func<int, int> func)
        //{
        //    return collection.Select(n => func(n));
        //}
    }
}
