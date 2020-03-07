using System;
using System.IO;

namespace Aula183FileFileInfoIOException {
    class Program {
        static void Main(string[] args) {
            string sourcePath = @"C:\Users\walla\Git\cursocsharp\Course\Aula183FileFileInfoIOException\file1.txt";
            string targetPath = @"C:\Users\walla\Git\cursocsharp\Course\Aula183FileFileInfoIOException\file2.txt";

            try {
                FileInfo fileinfo = new FileInfo(sourcePath);
                fileinfo.CopyTo(targetPath);
                string[] lines = File.ReadAllLines(sourcePath);
                foreach (string line in lines) {
                    Console.WriteLine(line);
                }
            } catch (IOException e) {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);

            }
        }
    }
}
