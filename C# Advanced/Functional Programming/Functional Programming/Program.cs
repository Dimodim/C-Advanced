using System;
using System.Linq;

namespace Functional_Programming
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            Action<string[]> PrintNames = names => Console.WriteLine(string.Join(Environment.NewLine,names));
            PrintNames(input);
        }
    }
}
