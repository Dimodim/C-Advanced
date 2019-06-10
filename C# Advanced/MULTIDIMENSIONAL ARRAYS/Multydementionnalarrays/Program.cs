using System;
using System.Collections.Generic;
using System.Linq;

namespace Multydementionnalarrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int input= int.Parse(Console.ReadLine());
            int[,] box = new int[input,input];
            for (int row = 0; row < box.GetLength(0); row++)
            {
                int[] colElements = Console.ReadLine().Split(" ") .Select(int.Parse).ToArray();
                for (int col = 0; col < box.GetLength(1); col++)
                    box[row, col] = colElements[col];
            }
            int primeryDiagonal = 0;
            int seckondaryDiagonal = 0;

            for (int row = 0; row < box.GetLength(0); row++)
            {
                 primeryDiagonal += box[row, row];
            }
            
            for (int row = 1; row <=box.GetLength(0); row++)
            {
                
                seckondaryDiagonal += box[row-1, box.GetLength(0)-row];
                
            }
            Console.WriteLine(Math.Max(primeryDiagonal, seckondaryDiagonal) - Math.Min(primeryDiagonal,seckondaryDiagonal));
        }
    }
}
