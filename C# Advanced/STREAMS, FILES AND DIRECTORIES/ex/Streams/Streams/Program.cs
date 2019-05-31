using System;
using System.IO;

namespace Streams
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"text.txt";
            
            using (StreamReader streamReader = new StreamReader(path))
            {
                int counter = 0;
                while (true)
                {
                  
                    string test = streamReader.ReadLine();
                    if (test == null)
                    {
                        break;
                    }
                    
                    if (counter % 2 == 0)
                    {
                        
                        Console.WriteLine(Reversed(Replaced(test)));
                    }
                    
                        
                    counter++;
                }
            }
        }

        private static string Reversed(string curentLine)
        {
            int counter = 0;
            string[] split = curentLine.Split();
            string[] reversed = new string[split.Length];
            for (int i = split.Length - 1; i >= 0; i--)
            {
                reversed[counter] += split[i];
                counter++;
            }
            return string.Join(" ",reversed);
        }

        private static string Replaced(string test)
        {
            return  test.Replace("-", "@")
                .Replace(",", "@")
                .Replace(".", "@")
                .Replace("!", "@")
                .Replace("?", "@");
            
        }
    }
}
