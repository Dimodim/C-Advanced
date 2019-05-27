using System;
using System.Collections.Generic;
using System.Linq;

namespace Fast_Food
{
    class Program
    {
        static void Main(string[] args)
        {
            int amountOfFood = int.Parse(Console.ReadLine());
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var queue = new Queue<int>(numbers);
            int unserved = 0;
            var newQueue = new Queue<int>(numbers);
            int surved = 0;

            while (queue.Count != 0)
            {
                int currentOrder = queue.Dequeue();
                if (currentOrder+surved<amountOfFood)
                {
                    surved += currentOrder;
                }
                else
                {

                    unserved++;

                    break;
                }
            }
            Console.WriteLine(newQueue.Max());
            if (unserved == 0)
            {
                

                Console.WriteLine("Orders complete");
            }
            else
            {
                int amount = 0;
                while (queue.Count!=0)
                {
                    amount += queue.Dequeue();
                }
                Console.WriteLine($"Orders left: {amount}");
            }

        }
    }
}
