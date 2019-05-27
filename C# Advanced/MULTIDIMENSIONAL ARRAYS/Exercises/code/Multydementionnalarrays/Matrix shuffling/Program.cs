using System;
using System.Linq;

namespace Matrix_shuffling
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
                {
                    box[row, col] = colElements[col];
                }
            }
            while (true)
            {
                string[] input = Console.ReadLine().Split();
                if (input[0] == "END")
                {
                    break;
                }
                else if(input[0] == "swap")
                {
                    int row1 = int.Parse(input[1]);
                    int col1 = int.Parse(input[2]);
                    int row2 = int.Parse(input[3]);
                    int col2 = int.Parse(input[4]);
                    if(row1 < 0 || row1 >=sizes[0] || col1 < 0 || col1 >=sizes[1]
                        ||row2 < 0 || row2 >=sizes[0] || col2 < 0 || col2 >=sizes[1])
                    {
                        Console.WriteLine("Invalid input!");
                    }
                    else
                    {
                        string firstElement = box[row1, col1];
                        string seckondElement = box[row2, col2];
                        box[row1, col1] = seckondElement;
                        box[row2, col2] = firstElement;
                        for (int i = 0; i < box.GetLength(0); i++)
                        {
                            for (int j = 0; j < box.GetLength(1); j++)
                            {
                               // if (j == 0)
                               // {
                                    Console.Write(box[i, j]+" ");
                               // }
                               // else { 
                               //     Console.Write($" {box[i,j]}");
                               // }
                            }
                            Console.WriteLine();
                        }
                    }
                    
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
            }

        }
    }
}
