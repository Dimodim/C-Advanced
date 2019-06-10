using System;

namespace Knights_of_Honor
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
            Action<string[]> PrintNames = names => Console.WriteLine("Sir "+string.Join(Environment.NewLine+"Sir ", names));
            PrintNames(input);
        }
    }
}
