using System;
using System.Collections.Generic;

namespace Basic_Queue_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            


                string[] nsx = Console.ReadLine().Split();
                int n = int.Parse(nsx[0]);
                int s = int.Parse(nsx[1]);
                int x = int.Parse(nsx[2]);
                Queue<int> queu = new Queue<int>();
                string[] numbers = Console.ReadLine().Split();
                for (int i = 0; i < n; i++)
                {
                    int num = int.Parse(numbers[i]);
                    queu.Enqueue(num);
                }
                for (int i = 1; i <= s; i++)
                {
                    queu.Dequeue();
                }
                if (queu.Count <= 0)
                {
                    Console.WriteLine(0);

                }
                else if (queu.Contains(x))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    int smallestNum = queu.Peek();
                    for (int i = 0; i < queu.Count; i++)
                    {
                        int current = queu.Dequeue();
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
