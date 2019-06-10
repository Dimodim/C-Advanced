using System;
using System.Linq;

namespace Custom_Min_Function
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Func<int[], int> SmallestNumber = n =>
            {
                  int smallestNumber = int.MaxValue;
                  foreach (var item in n)
                  {
                      if (item < smallestNumber)
                      {
                          smallestNumber = item;
                      }
                  }

                  return smallestNumber;
            };
            Console.WriteLine(SmallestNumber(numbers));
            
        }
    }
}
