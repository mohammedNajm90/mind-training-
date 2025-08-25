using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace files
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.Write a program to create a text file and write "Hello File System" into it.

            string path = @"C:\Users\master\Desktop\R.txt";
            string content = "Hello File System";
            File.WriteAllText(path, content);
            //2.Read the content of a text file and print it line by line.
            string[] lines = File.ReadAllLines(path);

            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
            //3.Append "New Line Added" to an existing file without overwriting it.
            string AppendText = "New Line Added";
            File.AppendAllText(path, AppendText);

            //4.Copy a file from one directory to another.
            string NewPath = @"C:\Users\master\Desktop\R2.txt";
            File.Copy(path, NewPath);
            //5.Move a file to a new folder and rename it.
            string DestinationFolder = @"C:\Users\master\Documents\NewFolder";
            string FileName = "RenamedFile.txt";
            Directory.CreateDirectory(@"C:\Users\master\Documents\NewFolder4");
            File.Move(path, DestinationFolder);
            //6.Delete a file safely (no exception if the file does not exist).
            File.Delete(DestinationFolder);
            //7.List all files in a given directory and print their names.
            string path0 = @"C:\Users\master\Desktop\Hill2";
            string[] files = Directory.GetFiles(path0);
            foreach (string file in files)
            {
                Console.WriteLine(Path.GetFileName(file));
            }
            //8.List all .txt files in a directory (and subdirectories).
            string directoryPath = @"C:\Users\master\Documents\NewFolder";
            if (Directory.Exists(directoryPath))
            {
                string[] txtFiles = Directory.GetFiles(directoryPath, "*.txt");
                foreach (string file in txtFiles)
                {
                    Console.WriteLine(file);
                }
            }
            else
            {
                Console.WriteLine("File not found.");
            }
            //9.Write a program to get the size (in KB/MB) of all files in a folder.
            string[] files0 = Directory.GetFiles(path);

            foreach (string file in files)
            {

                FileInfo fileInfo = new FileInfo(path);
                long sizeInBytes = fileInfo.Length;

                double sizeInKB = sizeInBytes / 1024.0;
                double sizeInMB = sizeInKB / 1024.0;
                Console.WriteLine($" {fileInfo.Name}");
                Console.WriteLine($"Size: {sizeInKB:F2} KB | {sizeInMB:F2} MB\n");

            }
            //10.Write a program that counts how many words are in a file.
            string filePath = @"C:\Users\master\Documents\sample.txt";
            if (File.Exists(filePath))
            {
                string content1 = File.ReadAllText(filePath);

                string[] words = Regex.Split(content1, @"\W+");
                int wordCount = 0;
                foreach (string word in words)
                {
                    if (!string.IsNullOrWhiteSpace(word))
                        wordCount++;
                }

                Console.WriteLine($"Total number of words: {wordCount}");
            }
            else
            {
                Console.WriteLine("File not found.");
            }
            //11.Use FileStream to write and then read data from a file.
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine(content);
            }
            using (StreamReader reader = new StreamReader(filePath))
            {
                string cont = reader.ReadToEnd();
                Console.WriteLine(content);
            }
            //12.Monitor a folder using FileSystemWatcher and display a message whenever a file is created.
            FileSystemWatcher watcher = new FileSystemWatcher();
            watcher.Path = directoryPath;
            watcher.NotifyFilter = NotifyFilters.FileName;
            watcher.Filter = "*.*";
            watcher.Created += (sender, e) =>
            {
                Console.WriteLine($"A new file has been created: {e.Name}");
            };
            watcher.EnableRaisingEvents = true;
            //13.Write a program to compress a text file using GZipStream.
            string sourceFile = "original.txt";
            string compressedFile = "compressed.gz";
            using (FileStream originalFileStream = new FileStream(sourceFile, FileMode.Open, FileAccess.Read))
            using (FileStream compressedFileStream = new FileStream(compressedFile, FileMode.Create))
            using (GZipStream compressionStream = new GZipStream(compressedFileStream, CompressionMode.Compress))
            {
                originalFileStream.CopyTo(compressionStream);
            }

            Console.WriteLine("The file has been compressed successfully.");

            //14.Write a program to encrypt and decrypt a file using simple XOR or AES.
            //15.Read a very large file line by line without loading the entire file into memory.
            string Path = "largefile.txt";

            using (StreamReader reader = new StreamReader(Path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }




            Console.ReadKey();
        }

    }
}
