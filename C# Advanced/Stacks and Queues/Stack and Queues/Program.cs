using System;
using System.Collections.Generic;
using System.Linq;

namespace Stack_and_Queues
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nsx = Console.ReadLine().Split();
            int n = int.Parse(nsx[0]);
            int s = int.Parse(nsx[1]);
            int x = int.Parse(nsx[2]);
            Stack<int> stack = new Stack<int>();
            string[] numbers = Console.ReadLine().Split();
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(numbers[i]);
                stack.Push(num);
            }
            for (int i = 1; i <=s; i++)
            {
                stack.Pop();
            }
            if (stack.Count <= 0)
            {
                Console.WriteLine(0);
                
            }
            else if (stack.Contains(x))
            {
                Console.WriteLine("true");
            }
            else
            {
                int smallestNum = stack.Pop();
                for (int i = 0; i < stack.Count; i++)
                {
                    int current = stack.Pop();
                    if (current < smallestNum)
                    {
                        smallestNum = current;
                    }
                }
                Console.WriteLine(smallestNum);
            }
            

        }
    }
}
