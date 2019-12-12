using System;
using System.Collections.Generic;
using System.IO;

namespace ReadIntergerFromTextFile
{
    /// <summary>
    /// Reads integers from a text file. If the during reading a row does not contain an integer throw FileParseException and pass it to the calling method.
    /// </summary>
    internal class Program
    {
        private static string _fileName;

        private static void Main(string[] args)
        {
            var intergerList = new List<int>();
            Environment.CurrentDirectory = @"E:\LearningSourceCSharp\TextFilesData";
            try
            {
                Console.WriteLine("Please enter file name!");
                _fileName = Console.ReadLine();
                Console.WriteLine("Press any key to read interger from {0}.", _fileName);
                Console.ReadKey(true);
                intergerList = ReadIntergerFromLines(_fileName);
                foreach (int j in intergerList)
                {
                    Console.Write(" " + j);
                }
                Console.WriteLine("");
                Console.WriteLine("Press any key to exit!");
                Console.ReadKey(true);
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Cannot found the file {0} at directory {1}!", _fileName, Directory.GetCurrentDirectory());
            }
            catch (FileParseException ex)
            {
                Console.WriteLine("There is a problem occur when reading file");
                Console.Error.WriteLine(ex.Message);
            }
            catch (IOException ex)
            {
                Console.WriteLine("Invalid path");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Thank you for using our software!");
            }
        }

        /// <summary>
        /// Read interger value from each line, then add it to the list
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        private static List<int> ReadIntergerFromLines(string fileName)
        {
            var numberList = new List<int>();
            string line;
            int count = 0;
            using (StreamReader sr = new StreamReader(fileName))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    count++;
                    if (!int.TryParse(line, out int number))
                    {
                        string error = "Cannot parse file at line :" + count;
                        throw new FileParseException(error, fileName, count);
                    }
                    else
                    {
                        numberList.Add(number);
                    }
                }
            }
            return numberList;
        }
    }
}