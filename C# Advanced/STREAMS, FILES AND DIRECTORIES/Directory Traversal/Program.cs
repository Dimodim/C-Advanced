using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Directory_Traversal
{
    class Program
    {
        static void Main(string[] args)
        {
            string directory = Console.ReadLine();

            var dirInfo = new Dictionary<string, Dictionary<string, double>>();

            DirectoryInfo directorySelected = new DirectoryInfo(directory);

            FileInfo[] allFiles = directorySelected.GetFiles();
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)+@"/report.txt";

            foreach (var curentFile in allFiles)
            {
                string name = curentFile.Name;
                double size = curentFile.Length / 1024d;
                string ext = curentFile.Extension;
                if (!dirInfo.ContainsKey(ext))
                {
                    dirInfo.Add(ext, new Dictionary<string, double>());
                }
                if (!dirInfo[ext].ContainsKey(name))
                {
                    dirInfo[ext].Add(name, size);
                }
            }
            foreach (var (key,value) in dirInfo.OrderByDescending(x=>x.Value.Keys.Count))
            {
                File.AppendAllText(path, $"{key}{Environment.NewLine}");
                foreach (var item in value.OrderBy(x=>x.Value).ThenBy(x=>x.Key))
                {
                    File.AppendAllText(path,$"--{item.Key} - {item.Value:f3}kb{Environment.NewLine}");
                }
            }
            
        }
    }
}
