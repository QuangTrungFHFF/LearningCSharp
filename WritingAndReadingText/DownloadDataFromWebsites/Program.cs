using System;
using System.Diagnostics;
using System.IO;
using System.Net.Http;

namespace DownloadDataFromWebsites
{
    internal class Program
    {
        private const string webAddress = "https://s1.1zoom.me/big0/200/Houses_Vietnam_Saigon_Ho_502539.jpg";

        private static void Main(string[] args)
        {
            try
            {
                Environment.CurrentDirectory = @"E:\LearningSourceCSharp\TextFilesData";
                string currentPath = Directory.GetCurrentDirectory();
                Console.WriteLine("Please enter name of the file!");
                string fileName = Console.ReadLine();
                DownloadUri(fileName);
                Console.WriteLine("Press any key to open the file!");
                Console.ReadKey(true);
                OpenFile(fileName);
            }
            catch (PathTooLongException)
            {
                Console.WriteLine("Path file too long!");
            }
            catch (UnauthorizedAccessException ex)
            {
                Console.WriteLine("Path specified a file that is read-only");
                Console.WriteLine("-or-");
                Console.WriteLine("This operation is not supported on the current platform");
                Console.WriteLine("-or-");
                Console.WriteLine("Path specified a directory");
                Console.WriteLine("-or-");
                Console.WriteLine("The caller does not have the required permission");
                Console.Error.WriteLine(ex.Message);
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("Cannot found the path {0}", Directory.GetCurrentDirectory());
            }
            catch (NotSupportedException)
            {
                Console.WriteLine("File is not supported!");
            }
            catch (IOException ex)
            {
                Console.WriteLine("There is an error when modify the file!");
                Console.Error.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Thank you!");
            }
        }

        /// <summary>
        /// Download file from URI
        /// </summary>
        /// <param name="fileName"></param>
        private static async void DownloadUri(string fileName)
        {
            //Instance of Http client
            HttpClient client = new HttpClient();
            //Send request async
            HttpResponseMessage response = await client.GetAsync(webAddress);
            //Check if response is successful or not
            response.EnsureSuccessStatusCode();
            //Save file to local
            using (FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                await response.Content.CopyToAsync(fs);
            }
            Console.WriteLine("Finished");
        }

        /// <summary>
        /// Open the file
        /// </summary>
        /// <param name="fileName"></param>
        private static void OpenFile(string fileName)
        {
            if (!File.Exists(fileName))
            {
                Console.WriteLine("Cannot found {0} in directory {1}.", fileName, Directory.GetCurrentDirectory());
            }
            else
            {
                //Open image file
                ProcessStartInfo info = new ProcessStartInfo
                {
                    FileName = fileName,
                    UseShellExecute = true,
                    Verb = string.Empty,
                    CreateNoWindow = true
                };
                Process.Start(info);
            }
        }
    }
}