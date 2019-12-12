using System;
using System.IO;
using WritingDataLib;

namespace ReadingBinaryFiles
{
    /// <summary>
    /// Read a binary file. Create the same binary file. Compare 2 files
    /// </summary>
    internal class Program
    {
        private static string _fileNameIn;
        private static string _fileNameOut = "out.dat";

        private static void Main(string[] args)
        {
            try
            {
                Environment.CurrentDirectory = @"E:\LearningSourceCSharp\TextFilesData";
                Console.WriteLine("Please enter the file name!");
                _fileNameIn = Console.ReadLine();
                _fileNameOut = "out" + _fileNameIn;
                if (!File.Exists(_fileNameIn))
                {
                    Console.WriteLine("File {0} is not exist at {1}", _fileNameIn, Directory.GetCurrentDirectory());
                }
                else
                {
                    byte[] binaryArray = ReadBinaryFile(_fileNameIn);
                    Console.WriteLine("Successfully read file {0}. Press any key to continue!", _fileNameIn);
                    Console.ReadKey(true);
                    WritingBytes.WritingBytesArrayToFile(_fileNameOut, binaryArray);
                    Console.WriteLine("Successfully write file {0}. Press any key to continue!", _fileNameOut);
                    Console.ReadKey(true);
                }
                if (CompareTwoFiles(File.ReadAllBytes(_fileNameIn), File.ReadAllBytes(_fileNameOut)))
                {
                    Console.WriteLine("2 files are the same!");
                }
                else
                {
                    Console.WriteLine("2 files are different!");
                }
            }
            catch (PathTooLongException)
            {
                Console.WriteLine("Path is too long!");
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("Cannot found directory!");
            }
            catch (NotSupportedException)
            {
                Console.WriteLine("File is not supported!");
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("Path specified a file that is read-only");
                Console.WriteLine("-or-");
                Console.WriteLine("This operation is not supported on the current platform");
                Console.WriteLine("-or-");
                Console.WriteLine("Path specified a directory");
                Console.WriteLine("-or-");
                Console.WriteLine("The caller does not have the required permission");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Invalid Path");
            }
            catch (IOException ex)
            {
                Console.WriteLine("There is an error when modify the file!");
                Console.Error.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Thank you for using my software!");
            }
        }

        /// <summary>
        /// Load a binary file from current directory
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        private static byte[] ReadBinaryFile(string fileName)
        {
            byte[] binaryArray = File.ReadAllBytes(fileName);
            return binaryArray;
        }

        /// <summary>
        /// Compare 2 files
        /// </summary>
        /// <param name="firstArray"></param>
        /// <param name="secondArray"></param>
        /// <returns></returns>
        private static bool CompareTwoFiles(byte[] firstArray, byte[] secondArray)
        {
            if (firstArray.Length != secondArray.Length)
                return false;
            for (int i = 0; i < firstArray.Length; i++)
            {
                if (firstArray[i] != secondArray[i])
                    return false;
            }
            return true;
        }
    }
}