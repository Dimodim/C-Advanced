using System;

namespace TronRacers
{
    class Program
    {
        public static int fRow;
        public static int fCol;
        public static bool aRacerIsDead;
        public static int sRow;
        public static int sCol;
        public static char[,] field;
        
        public static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine());
            field = new char[fieldSize, fieldSize];
            for (int i = 0; i < field.GetLength(0); i++)
            {
                char[] input = Console.ReadLine().ToCharArray();
                for (int j = 0; j < field.GetLength(1); j++)
                {
                    field[i, j] = input[j];
                    if (input[j] == 's')
                    {
                        sRow = i;
                        sCol = j;
                    }
                    if (input[j] == 'f')
                    {
                        fRow = i;
                        fCol = j;
                    }
                }

            }
            while (true)
            {
                if (aRacerIsDead == true)
                {
                    break;
                }
                string[] input = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
                string f = input[0];
                string s = input[1];
                
                Move(f,'f');
                if (aRacerIsDead == true)
                {
                    break;
                }
                Move(s,'s');


            }
        }
        private static void MoveRight(char racer)
        {
            int currentRacerRow = 0;
            int currentRacerCol = 0;
            if (racer == 's')
            {
                currentRacerRow = sRow;
                currentRacerCol = sCol;
            }
            else
            {
                currentRacerRow = fRow;
                currentRacerCol = fCol;
            }
            if (currentRacerCol + 1 == field.GetLength(1))
            {
                currentRacerCol = 0;
            }
            else
            {
                currentRacerCol += 1;
            }

            RacersConditionCHeck(currentRacerRow, currentRacerCol);


            field[currentRacerRow, currentRacerCol] = racer;
            SetCordinates(currentRacerRow,currentRacerCol,racer);
        }
        private static void MoveLeft(char racer)
        {
            int currentRacerRow = 0;
            int currentRacerCol = 0;
            if (racer == 's')
            {
                currentRacerRow = sRow;
                currentRacerCol = sCol;
            }
            else
            {
                currentRacerRow = fRow;
                currentRacerCol = fCol;
            }
            if (currentRacerCol - 1 <0)
            {
                currentRacerCol = field.GetLength(1)-1;
            }
            else
            {
                currentRacerCol -= 1;
            }
            RacersConditionCHeck(currentRacerRow, currentRacerCol);


            field[currentRacerRow, currentRacerCol] = racer;
            SetCordinates(currentRacerRow, currentRacerCol, racer);
            
        }
        private static void MoveUp(char racer)
        {
            int currentRacerRow = 0;
            int currentRacerCol = 0;
            if (racer == 's')
            {
                currentRacerRow = sRow;
                currentRacerCol = sCol;
            }
            else
            {
                currentRacerRow = fRow;
                currentRacerCol = fCol;
            }
            if (currentRacerRow - 1 < 0)
            {
                currentRacerRow = field.GetLength(0) - 1;
            }
            else
            {
                currentRacerRow -= 1;
            }
            RacersConditionCHeck(currentRacerRow, currentRacerCol);


            field[currentRacerRow, currentRacerCol] = racer;
            SetCordinates(currentRacerRow, currentRacerCol, racer);


        }
        private static void MoveDown(char racer)
        {
            int currentRacerRow = 0;
            int currentRacerCol = 0;
            if (racer == 's')
            {
                currentRacerRow = sRow;
                currentRacerCol = sCol;
            }
            else
            {
                currentRacerRow = fRow;
                currentRacerCol = fCol;
            }
            if (currentRacerRow + 1 > field.GetLength(0)-1)
            {
                currentRacerRow = 0;
            }
            else
            {
                currentRacerRow += 1;
            }
            RacersConditionCHeck(currentRacerRow, currentRacerCol);


            field[currentRacerRow, currentRacerCol] = racer;
            SetCordinates(currentRacerRow, currentRacerCol, racer);


        }
        private static void SetCordinates(int currentRacerRow, int currentRacerCol, char racer)
        {
            if (racer == 's')
            {
                sRow = currentRacerRow;
                sCol = currentRacerCol;
            }
            else
            {
                fRow = currentRacerRow;
                fCol = currentRacerCol;
            }
        }
        private static void RacersConditionCHeck(int currentRacerRow, int currentRacerCol)
        {
            if (field[currentRacerRow, currentRacerCol] == 's' || field[currentRacerRow, currentRacerCol] == 'f')
            {
                field[currentRacerRow, currentRacerCol] = 'x';
                aRacerIsDead = true;

                string output = $"";
                for (int i = 0; i < field.GetLength(0); i++)
                {
                    for (int j = 0; j < field.GetLength(1); j++)
                    {
                        output += field[i, j];
                    }
                    output += Environment.NewLine;
                }
                Console.WriteLine(output);
            }
            
        }
        private static void Move(string direction, char racer)
        {
            if (direction == "up")
            {
                MoveUp(racer);
            }
            else if (direction == "down")
            {
                MoveDown(racer);
            }
            else if (direction == "left")
            {
                MoveLeft(racer);
            }
            else if (direction == "right")
            {
                MoveRight(racer);
            }
        }

    }
}
