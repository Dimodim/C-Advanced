using System;
using System.Collections.Generic;
using System.Linq;

namespace TrojanInvasion
{
    class Program
    {
        static void Main(string[] args)
        {
            int wavesOfTrijans = int.Parse(Console.ReadLine());
            int[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            List<int> PlatesOfSpartanDefence = new List<int>(input);
            Stack<int> wariors = new Stack<int>();
            
            for (int i = 1; i <=wavesOfTrijans; i++)
            {
                if (PlatesOfSpartanDefence.Count == 0)
                {
                    break;
                }
                int[] newWariors = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                if (i % 3 == 0)
                {
                    
                    int[] plate = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                    PlatesOfSpartanDefence.Add(plate[0]);
                    
                }
                

                foreach (var warior in newWariors)
                {
                    wariors.Push(warior);
                }
                while (true)
                {
                    if (wariors.Count== 0)
                    {
                        break;
                    }
                    if (PlatesOfSpartanDefence.Count == 0)
                    {
                        break;
                    }
                    int warior = wariors.Pop();
                    int plate = PlatesOfSpartanDefence[0];
                    PlatesOfSpartanDefence.RemoveAt(0);
                    
                    if (plate > warior)
                    {
                        plate-= warior;
                        warior = 0;
                    }else if (warior>plate)
                    {
                        warior -= plate;
                        plate = 0;
                    }
                    else if (plate == warior)
                    {
                        warior = 0;
                        plate = 0;
                    }
                    if (warior != 0)
                    {
                        wariors.Push(warior);
                    }
                    if (plate != 0)
                    {
                        PlatesOfSpartanDefence.Insert(0,plate);
                    }
                    
                }
                
                
            }
            if(PlatesOfSpartanDefence.Count == 0)
            {
                Console.WriteLine("The Trojans successfully destroyed the Spartan defense.");
                Console.WriteLine($"Warriors left: "+string.Join(", ",wariors));
            }
            else
            {
                Console.WriteLine("The Spartans successfully repulsed the Trojan attack.");
                Console.WriteLine($"Plates left: "+string.Join(", ", PlatesOfSpartanDefence));
            }
        }
    }
}
