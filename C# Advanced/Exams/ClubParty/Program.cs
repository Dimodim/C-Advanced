using System;
using System.Collections.Generic;
using System.Linq;

namespace ClubParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int halsCapacity = int.Parse(Console.ReadLine());
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Stack<string> commands = new Stack<string>(input);
            Queue<string> hals = new Queue<string>();
            Dictionary<string, List<int>> keyValues = new Dictionary<string, List<int>>();
            string curentRoom = "";
            int pplInCurentRoom = 0;

            for (int i = 0; i < input.Length; i++)
            {
                
                string curentElement = commands.Pop();
                char[] numberOrCharecter = curentElement.ToCharArray();
                if (char.IsLetter(numberOrCharecter[0]))
                {
                    hals.Enqueue(curentElement);
                    keyValues[curentElement] = new List<int>();

                    if (curentRoom == "")
                    {
                        curentRoom = hals.Dequeue();

                    }

                }
                else
                {
                    if (curentRoom == "")
                    {

                    }
                    else
                    {
                        int number = int.Parse(curentElement);
                        if (number > halsCapacity)
                        {

                        }
                        else
                        {
                            if (number + pplInCurentRoom > halsCapacity)
                            {
                                Console.WriteLine($"{curentRoom} -> "+string.Join(", ",keyValues[curentRoom]));
                                if (hals.Count > 0)
                                {
                                    curentRoom = hals.Dequeue();
                                    
                                    if (number <= halsCapacity)
                                    {
                                        keyValues[curentRoom].Add(number);
                                        pplInCurentRoom = number;
                                    }
                                    

                                }
                            }
                            else
                            {
                                pplInCurentRoom += number;
                                keyValues[curentRoom].Add(number);
                            }
                        }
                        
                    }
                }    
            }
        }
    }
}
