using System;
using System.IO;
using System.IO.Compression;

namespace Zip_and_Extract
{
    class Program
    {
        static void Main(string[] args)
        {
            string startPath = ".";     //Directory to zip
            string zipPath = "../../../result.zip"; //zipFile name 
            string extractPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);//ExtractDirectory

            ZipFile.CreateFromDirectory(startPath, zipPath);

            ZipFile.ExtractToDirectory(zipPath, extractPath);
        }
    }
}
