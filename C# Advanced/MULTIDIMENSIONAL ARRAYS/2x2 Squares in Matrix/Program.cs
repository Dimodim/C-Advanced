using System;
using System.Linq;

namespace _2x2_Squares_in_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string[,] box = new string[sizes[0], sizes[1]];
            for (int row = 0; row < box.GetLength(0); row++)
            {
                string[] colElements = Console.ReadLine().Split(" ").ToArray();
                for (int col = 0; col < box.GetLength(1); col++)
                    box[row, col] = colElements[col];
            }
            int andAnotherOne = 0;
            for (int row = 0; row < box.GetLength(0)-1; row++)
            {
                for (int cow = 0; cow < box.GetLength(1)-1; cow++)
                {
                    if(
                        box[row,cow] == box[row, cow+1]
                        && box[row, cow] == box[row+1, cow]
                        && box[row, cow] == box[row + 1, cow + 1]
                        )
                    {
                        andAnotherOne++;
                    }
                }
            }
            Console.WriteLine(andAnotherOne);

        }
    }
}
