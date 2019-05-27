using System;
using System.Collections.Generic;
using System.Linq;

namespace Fashion_Boutique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            var queue = new Queue<int>(numbers);
            int capacity = int.Parse(Console.ReadLine());
            int racks = 1;
            int currentRack = 0;
            while (queue.Count != 0)
            {
                int pieceOfClothing = queue.Dequeue();
                if (currentRack + pieceOfClothing > capacity)
                {
                    racks++;
                    currentRack = pieceOfClothing;
                }
                else
                {
                    currentRack += pieceOfClothing;
                }
            }
            Console.WriteLine(racks);
            
        }
    }
}
