using System;
using System.Linq;

namespace Helen_sAbduction
{
    class Program
    {
        public static int parisEnergy;
        public static char[][] field;
        public static bool abductHelen;
        public static int parisRow = 0;
        public static int parisCol = 0;
        public static int helaRow = 0;
        public static int helaCol = 0;

        public static void Main(string[]args)
        {
            parisEnergy = int.Parse(Console.ReadLine());
            int size = int.Parse(Console.ReadLine());
            field = new char[size][];
            abductHelen = false;
            parisRow = 0;
            parisCol = 0;
            for (int row = 0; row < field.Length; row++)
            {
                
                char[] input = Console.ReadLine().ToCharArray();
                field[row] = new char[input.Length];

                for (int col = 0; col < field[row].Length; col++)
                {
                    field[row][col] = input[col];
                    if (field[row][col] == 'H')
                    {
                        helaRow = row;
                        helaCol = col;
                    }
                    else if (field[row][col] == 'P')
                    {
                        parisRow = row;
                        parisCol = col;
                    }
                    
                }
                
            }
            while (true)
            {
                if (abductHelen == true||parisEnergy<=0)
                {
                    break;
                }
                string[] input = Console.ReadLine().Split();
                string move = input[0];
                int enemyRow = int.Parse(input[1]);
                int enemyCol = int.Parse(input[2]);
                field[enemyRow][enemyCol] = 'S';
                if(move == "up")
                {
                    MoveUp();
                }else if (move == "down")
                {
                    MoveDow();
                }else if(move == "left")
                {
                    MoveLeft();
                }else if (move == "right")
                {
                    MoveRight();
                }


            }
            if (abductHelen == true)
            {
                Console.WriteLine($"Paris has successfully abducted Helen! Energy left: {parisEnergy}");
                foreach (var row in field)
                {
                    foreach (var col in row)
                    {
                        Console.Write($"{col}");
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine($"Paris died at {parisRow};{parisCol}.");
                foreach (var row in field)
                {
                    foreach (var col in row)
                    {
                        Console.Write($"{col}");
                    }
                    Console.WriteLine();
                }
            }

        }

        public static void MoveLeft()
        {
            parisEnergy -= 1;
            if (parisCol - 1 < 0)
            {
                
            }
            else
            {
                field[parisRow][parisCol] = '-';
                if (field[parisRow][parisCol - 1] == 'S')
                {
                    parisEnergy -= 2;
                    if (parisEnergy <= 0)
                    {
                        field[parisRow][parisCol - 1] = 'X';
                    }
                    else
                    {
                        field[parisRow][parisCol - 1] = 'P';

                    }
                }
                else if (field[parisRow][parisCol - 1] == 'H')
                {
                    field[parisRow][parisCol] = '-';
                    field[parisRow][parisCol - 1] = '-';

                    abductHelen = true;
                }
                else
                {
                    
                    if (parisEnergy <= 0)
                    {
                        field[parisRow][parisCol - 1] = 'X';
                    }
                    else
                    {
                        field[parisRow][parisCol - 1] = 'P';
                    }

                }
                parisCol -= 1;

            }
        }


        public static void MoveUp()
        {
            parisEnergy--;
            if (parisRow - 1 < 0)
            {
                
            }
            else
            {
                field[parisRow][parisCol] = '-';
                if (field[parisRow - 1][parisCol] == 'S')
                {
                    parisEnergy -= 2;
                    if (parisEnergy <=0)
                    {
                        field[parisRow - 1][parisCol] = 'X';
                    }
                    else
                    {
                        field[parisRow - 1][parisCol] = 'P';
                        
                    }
                }
                else if (field[parisRow - 1][parisCol] == 'H')
                {
                    field[parisRow][parisCol] = '-';
                    field[parisRow-1][parisCol] = '-';

                    abductHelen = true;
                }
                else
                {
                    
                    if (parisEnergy <= 0)
                    {
                        field[parisRow - 1][parisCol] = 'X';
                    }
                    else
                    {
                        field[parisRow - 1][parisCol] = 'P';
                    }

                }
                parisRow -= 1;
                
            }
        }
        public static void MoveDow()
        {
            parisEnergy--;
            if (parisRow + 1 >=field.Length)
            {
                
            }
            else
            {
                field[parisRow][parisCol] = '-';
                if (field[parisRow + 1][parisCol] == 'S')
                {
                    parisEnergy -= 2;
                    if (parisEnergy <=0)
                    {
                        field[parisRow + 1][parisCol] = 'X';
                    }
                    else
                    {
                        field[parisRow + 1][parisCol] = 'P';
                        
                    }
                }
                else if (field[parisRow + 1][parisCol] == 'H')
                {
                    field[parisRow][parisCol] = '-';
                    field[parisRow+1][parisCol] = '-';

                    abductHelen = true;
                }
                else
                {
                    
                    if (parisEnergy <= 0)
                    {
                        field[parisRow + 1][parisCol] = 'X';
                    }
                    else
                    {
                        field[parisRow + 1][parisCol] = 'P';
                    }

                }
                parisRow += 1;
                
            }
        }
        public static void MoveRight()
        {
            parisEnergy--;
            if (parisCol + 1 > field[parisRow].Length)
            {
                
            }
            else
            {
                field[parisRow][parisCol] = '-';
                if (field[parisRow][parisCol + 1] == 'S')
                {
                    parisEnergy -= 2;
                    if (parisEnergy <= 0)
                    {
                        field[parisRow][parisCol + 1] = 'X';
                    }
                    else
                    {
                        field[parisRow][parisCol + 1] = 'P';

                    }
                }
                else if (field[parisRow][parisCol + 1] == 'H')
                {
                    field[parisRow][parisCol] = '-';
                    field[parisRow][parisCol + 1] = '-';

                    abductHelen = true;
                }
                else
                {
                    
                    if (parisEnergy <= 0)
                    {
                        field[parisRow][parisCol + 1] = 'X';
                    }
                    else
                    {
                        field[parisRow][parisCol + 1 ] = 'P';
                    }

                }
                parisCol -= 1;

            }
        }


    }
}
