using System;
using System.Linq;
using System.Collections.Generic;

namespace Maximal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[,] matrix = new int[sizes[0], sizes[1]];
            string numbersToPrint = "";
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] colElements = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                 matrix[row, col] = colElements[col];
            }
            int biggestSum = int.MinValue;
            for (int row = 1; row < matrix.GetLength(0) - 1; row++)
            {
                for (int cow = 1; cow < matrix.GetLength(1) - 1; cow++)
                {
                    int sum = 0;
                    for (int r = row - 1; r <=row + 1; r++)
                    {
                        for (int c = cow - 1; c <=cow + 1; c++)
                        {
                            sum += matrix[r, c];
                            
                        }
                    }
                    if (sum>biggestSum)  
                    {
                        biggestSum = sum;
                        numbersToPrint = "";
                        for (int r = row - 1; r <= row + 1; r++)
                        {
                            for (int c = cow - 1; c <= cow + 1; c++)
                            {
                                numbersToPrint += matrix[r, c] + " ";

                            }
                        }
                    }
                    
                }
            }
            string[] endNumbers = numbersToPrint.Split(" ", StringSplitOptions.RemoveEmptyEntries);



            Console.WriteLine($"Sum = {biggestSum}");
            Console.WriteLine($"{endNumbers[0]} {endNumbers[1]} {endNumbers[2]}");
            Console.WriteLine($"{endNumbers[3]} {endNumbers[4]} {endNumbers[5]}");
            Console.WriteLine($"{endNumbers[6]} {endNumbers[7]} {endNumbers[8]}");


        }
    }
}
