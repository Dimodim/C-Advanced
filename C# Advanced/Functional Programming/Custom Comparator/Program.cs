using System;
using System.Linq;

namespace Custom_Comparator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Console.WriteLine(string.Join(" ",numbers.OrderBy(x => x % 2 != 0).ThenBy(x=>x % 2 == 0)));
        }
    }
}
