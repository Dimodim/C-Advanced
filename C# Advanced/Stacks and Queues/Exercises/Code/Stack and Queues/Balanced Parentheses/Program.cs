using System;
using System.Collections.Generic;
using System.Linq;

namespace Balanced_Parentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] parentheses = Console.ReadLine().ToCharArray();
            if ((parentheses.Length% 2 == 0))
            {
                Queue<char> left = new Queue<char>();
                Queue<char> right = new Queue<char>();
                for (int i = 0; i <parentheses.Length; i++)
                {
                    if (i >= (parentheses.Length / 2))
                    {
                        right.Enqueue(parentheses[i]);
                    }
                    else
                    {
                        left.Enqueue(parentheses[i]);

                    }
                }
                List<char> rightReversed = right.Reverse().ToList();
                Queue<char> newRight = new Queue<char>(rightReversed);

                bool yes = true;
                while (left.Count != 0)
                {
                    char equalLeft = left.Dequeue();
                    char equalRight = newRight.Dequeue();
                    if (equalLeft=='('&&equalRight!=')'|| equalLeft == '{' && equalRight != '}' || equalLeft == '[' && equalRight != ']')
                    {
                        Console.WriteLine("NO");
                        yes = false;
                        break;
                    }
                }
                if (yes == true)
                {
                    Console.WriteLine("YES");
                }
                    
                
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
