using System;

namespace Snake_Moves
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] size = Console.ReadLine().Split();
            int row = int.Parse(size[0]);
            int col = int.Parse(size[1]);
            char[] inputText = Console.ReadLine().ToCharArray();
            char[,] field = new char[row,col];
            int counter = 0;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    field[i, j] = inputText[counter];
                    counter++;
                    if (counter>= inputText.Length)
                    {
                        counter = 0;
                    }
                }
            }
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write(field[i,j]);
                }
                Console.WriteLine();
            }
        }
    }
}
