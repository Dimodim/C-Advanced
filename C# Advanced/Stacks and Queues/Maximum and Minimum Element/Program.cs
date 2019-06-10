using System;
using System.Collections.Generic;
using System.Linq;

namespace Maximum_and_Minimum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int cycles = int.Parse(Console.ReadLine());
            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < cycles; i++)
            {
                string[] input = Console.ReadLine().Split();
                string command = input[0];

                switch (command)
                {
                    case "1":
                        int number = int.Parse(input[1]);
                        stack.Push(number);
                        break;
                    case "2":
                        if (stack.Count != 0)
                        {
                            stack.Pop();
                        }
                        break;
                    case "3":
                        var coppy = stack.OrderByDescending(x=>x).ToList();
                        if (coppy.Count != 0)
                        {
                            Console.WriteLine(coppy[0]);
                        }
                        break;
                    case "4":
                        var coppy1 = stack.OrderBy(x => x).ToList();
                        if (coppy1.Count != 0)
                        {
                            Console.WriteLine(coppy1[0]);
                        }
                        break;
                }
                
            }
            Console.WriteLine(string.Join(", ",stack));
            //while (stack.Count != 0)
            //{
            //    int num = stack.Pop();
            //    Console.Write($"{num}, ");
            //}
        }
    }
}
