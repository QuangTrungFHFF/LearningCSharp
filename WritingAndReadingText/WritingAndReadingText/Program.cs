using System;
using System.IO;

namespace ReadTextFromFiles
{
    /// <summary>
    /// Reading text from files
    /// </summary>
    internal class Program
    {
        private static readonly string _currentPath = Directory.GetCurrentDirectory();

        private static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Environment.CurrentDirectory = @"E:\LearningSourceCSharp\TextFilesData"; //Set current directory to different folder
            Console.WriteLine(_currentPath);
            Console.WriteLine("Read test from file Frankfurt.txt into one line");
            Console.ReadKey(true);
            try
            {
                string output = ReadFilesToEnd("Frankfurt");
                Console.WriteLine(output);
            }
            catch (IOException ex)
            {
                Console.WriteLine("The file could not be read!");
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("Read test from file Frankfurt.txt line by line");
            Console.ReadKey(true);
            try
            {
                ReadFilesToLines("Frankfurt");
            }
            catch (IOException ex)
            {
                Console.WriteLine("The file could not be read!");
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// Read all text from file and return a single string
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        private static string ReadFilesToEnd(string fileName)
        {
            string path = _currentPath + @"\" + fileName + ".txt";
            using var sr = new StreamReader(path);
            return sr.ReadToEnd();
        }

        /// <summary>
        /// Read text file line by line
        /// </summary>
        /// <param name="fileName"></param>
        private static void ReadFilesToLines(string fileName)
        {
            string path = _currentPath + @"\" + fileName + ".txt";
            string line = String.Empty;
            using var sr = new StreamReader(path);
            while ((line = sr.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
            return;
        }
    }
}