using System;
using System.IO;

namespace FileSystem
{
    class Solutions
    {
        //1.Write a program to create a text file and write "Hello File System" into it.
        public static void WriteToFile(String text, String fileName)
        {
            File.WriteAllText(fileName, text);
        }

        //2.Read the content of a text file and print it line by line. 
        public static void ReadFromFile(String fileName)
        {
            string readText = File.ReadAllText(fileName);
            Console.WriteLine(readText);
        }

        //3.Append "New Line Added" to an existing file without overwriting it.
        public static void AppendAllText(string path, string contents)
        {
            File.AppendAllText(path, contents);
        }

        //4.Copy a file from one directory to another.
        public static void Copy(string sourceFileName, string destFileName)
        {
            File.Copy(sourceFileName, destFileName,true);
        }

        //5.Move a file to a new folder and rename it
        public static void Move(string sourceFileName, string destFileName)
        {
            File.Move(sourceFileName, destFileName);
        }

        //6.Delete a file safely (no exception if the file does not exist)
        public static void Delete(string path)
        {
            File.Delete(path);
        }

        //7.List all files in a given directory and print their names.
        public static void GetFiles(string directoryPath)
        {
            string[] files = Directory.GetFiles(directoryPath);
            foreach (string fileName in files)
                Console.WriteLine(fileName.Substring(fileName.LastIndexOf(@"\")+1));
        }

        //8.List all.txt files in a directory (and subdirectories).
        public static void GetTxtFiles(string directoryPath)
        {
            string[] files = Directory.GetFiles(directoryPath,"*.txt");
            foreach (string fileName in files)
                Console.WriteLine(fileName.Substring(fileName.LastIndexOf(@"\") + 1));
        }

        //10.Write a program that counts how many words are in a file.
        public static void Counts(String path)
        {
            string readText = File.ReadAllText(path);
            String[] words;
            words = readText.Split(' ');
            int count = 0;
            foreach (var word in words)
            {
                count++;
            }
            Console.WriteLine("Number of words: " + count);
            
        }

    }
}
