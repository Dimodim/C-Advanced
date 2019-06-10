using System;
using System.Linq;

namespace Reverse_and_Exclude
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int exclude = int.Parse(Console.ReadLine());

            Console.WriteLine(
                string.Join(" ",
                input = input.Reverse()
                .Where(x => x % exclude != 0)
                .ToArray()));
        }
    }
}
