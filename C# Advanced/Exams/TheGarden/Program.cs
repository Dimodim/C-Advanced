using System;
using System.Collections.Generic;

namespace TheGarden
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[][] field = new char[n][];

            for (int i = 0; i < field.Length; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                field[i] = new char[input.Length];

                for (int j = 0; j < field[i].Length; j++)
                {
                    field[i][j] = char.Parse(input[j]);
                }
            }
            Dictionary<char, int> crops = new Dictionary<char, int>();
            crops.Add('C', 0);
            crops.Add('L', 0);
            crops.Add('P', 0);
            crops.Add('H', 0);
            while (true)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (input[0] == "End")
                {
                    break;
                }
                if (input[0] == "Harvest")
                {
                    int row = int.Parse(input[1]);
                    int col = int.Parse(input[2]);
                    if (row < 0 || row >= field.Length)
                    {

                    }
                    else
                    {
                        if (col < 0 || col >= field[row].Length)
                        {

                        }
                        else
                        {
                            if (field[row][col] == 'P')
                            {
                                field[row][col] = ' ';
                                crops['P']++;
                            }
                            else if (field[row][col] == 'C')
                            {
                                field[row][col] = ' ';
                                crops['C']++;
                            }
                            else if (field[row][col] == 'L')
                            {
                                field[row][col] = ' ';
                                crops['L']++;
                            }
                        }
                    }
                }
                else if (input[0] == "Mole")
                {
                    int row = int.Parse(input[1]);
                    int col = int.Parse(input[2]);
                    string direction = input[3];
                    if (row < 0 || row >= field.Length)
                    {

                    }
                    else
                    {
                        if (col < 0 || col >= field[row].Length)
                        {

                        }
                        else
                        {
                            if (direction == "up")
                            {
                                for (int i = row; i >= 0; i -= 2)
                                {
                                    if (field[i][col] != ' ')
                                    {
                                        field[i][col] = ' ';
                                        crops['H']++;
                                    }

                                }
                            }
                            else if (direction == "down")
                            {
                                for (int i = row; i < field.Length; i += 2)
                                {
                                    if (field[i][col] != ' ')
                                    {
                                        field[i][col] = ' ';
                                        crops['H']++;
                                    }
                                }
                            }
                            else if (direction == "left")
                            {
                                for (int i = col; i >= 0; i -= 2)
                                {

                                    if (field[row][i] != ' ')
                                    {
                                        field[row][i] = ' ';
                                        crops['H']++;
                                    }


                                }
                            }
                            else if (direction == "right")
                            {
                                for (int i = col; i < field[col].Length; i += 2)
                                {
                                    if (field[row][i] != ' ')
                                    {
                                        field[row][i] = ' ';
                                        crops['H']++;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            foreach (var col in field)
            {
                Console.WriteLine(string.Join(" ", col));
            }
            Console.WriteLine($"Carrots: {crops['C']}");
            Console.WriteLine($"Potatoes: {crops['P']}");
            Console.WriteLine($"Lettuce: {crops['L']}");
            Console.WriteLine($"Harmed vegetables: {crops['H']}");
        }
    }
}
