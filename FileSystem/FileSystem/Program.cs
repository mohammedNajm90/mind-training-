using System;
using System.IO;

namespace FileSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            String path1 = @"C:\Users\LENOVO\source\repos\FileSystem\FileSystem\Folder1\File1.txt";
            String path2 = @"C:\Users\LENOVO\source\repos\FileSystem\FileSystem\Folder2\File2.txt";
            String path3 = @"C:\Users\LENOVO\source\repos\FileSystem\FileSystem\Folder2\File3.txt";

            String directoryPath1 = @"C:\Users\LENOVO\source\repos\FileSystem\FileSystem\Folder1\";

            Solutions.WriteToFile("Hello File System",path1);
            Solutions.ReadFromFile(path1);
            Solutions.AppendAllText(path1, " New Line Added");
            Solutions.ReadFromFile(path1);
            Solutions.Copy(path1, path2);
            Solutions.ReadFromFile(path2);
            //Solutions.Move(path1, path3);
            //Solutions.ReadFromFile(path3);
            //Solutions.Delete(path1);
            Solutions.GetFiles(directoryPath1);
            Console.WriteLine();
            Solutions.GetTxtFiles(directoryPath1);
            Solutions.Counts(path1);
        }
    }
}
