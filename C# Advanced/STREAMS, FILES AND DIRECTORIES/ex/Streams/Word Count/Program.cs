using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace Word_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = File.ReadAllLines("words.txt");
            string[] text = File.ReadAllLines("text.txt");
            Dictionary<string, int> wordsAndCount = new Dictionary<string, int>();
            
            foreach (var word in words)
            {
                if (!wordsAndCount.ContainsKey(word))
                {
                    wordsAndCount.Add(word, 0);
                }
                foreach (var item in text)
                {
                    var splited = item.ToLower().Split(new char[] {' ',',','-','.','!','?'},StringSplitOptions.RemoveEmptyEntries);
                    foreach (var part in splited)
                    {
                        if (part==word)
                        {
                            wordsAndCount[word]++;
                        }
                    }
                    
                }
            }
            foreach (var item in wordsAndCount.OrderBy(x=>x.Value))
            {
                File.AppendAllText("expectedResult.txt",$"{item.Key} - {item.Value}{Environment.NewLine}");
            }
            foreach (var item in wordsAndCount)
            {
                File.AppendAllText("actuallResult.txt", $"{item.Key} - {item.Value}{Environment.NewLine}");
            }
        }
    }
}
