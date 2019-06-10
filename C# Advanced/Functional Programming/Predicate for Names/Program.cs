using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Predicate_for_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int boundry = int.Parse(Console.ReadLine());
            var names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Print(names,n=>n.Length<=boundry);
        }
        public static void Print(IEnumerable<string> collection, Func<string,bool>func)
        {
            Console.WriteLine(string.Join(Environment.NewLine,collection.Where(func)));
        }
        
    }
}
