using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace MakeASalad
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> vegies = new Queue<string>(Console.ReadLine().Split());
            Stack<int> salads = new Stack<int>();
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            List<int> finsihedSalads = new List<int>();
            //List<int> unfinishedSalads = new List<int>();
            //List<string> vegiesLeft = new List<string>();

            foreach (var item in input)
            {
                salads.Push(item);
            }

            int currentSalad = 0;

            while (true)
            {
                if (vegies.Count <= 0 || salads.Count <= 0)
                {
                    break;
                }
                if (currentSalad <= 0)
                {
                    currentSalad = salads.Pop();
                    finsihedSalads.Add(currentSalad);
                }
                
                string currentVegie = vegies.Dequeue();

                int vegieCalories = ReturnCalories(currentVegie);

                currentSalad -= vegieCalories;
                
            }
            Console.WriteLine(string.Join(" ",finsihedSalads));
            if (vegies.Count <= 0)
            {
                Console.WriteLine(string.Join(" ",salads));
            }
            else if(salads.Count<=0)
            {
                Console.WriteLine(string.Join(" ", vegies));
            }
        }

        private static int ReturnCalories(string currentVegie)
        {
            int calories = 0;
            if (currentVegie == "tomato")
            {
                calories = 80;
            }
            else if (currentVegie == "potato")
            {
                calories = 215;
            }
            else if (currentVegie == "lettuce")
            {
                calories = 109;
            }
            else if (currentVegie == "carrot")
            {
                calories = 136;
            }
            
            return calories;
        }
    }
}
