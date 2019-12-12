using System;
using System.Diagnostics;
using System.IO;
using System.Net.Http;

namespace DownloadDataFromWebsites
{
    class Program
    {
        private static string webAddress = "https://s1.1zoom.me/big0/200/Houses_Vietnam_Saigon_Ho_502539.jpg";

        static void Main(string[] args)
        {
            Environment.CurrentDirectory = @"E:\LearningSourceCSharp\TextFilesData";
            string currentPath = Directory.GetCurrentDirectory();
            Console.WriteLine("Please enter name of the file!");
            string fileName = Console.ReadLine();
            DownloadUri(fileName);
            Console.ReadKey(true);
            
            //Open image file
            ProcessStartInfo info = new ProcessStartInfo();
            info.FileName = @"hcm2.jpg";           
            info.UseShellExecute = true;            
            info.Verb = string.Empty;
            info.CreateNoWindow = true;
            Process.Start(info);

        }

        /// <summary>
        /// Download file from URI
        /// </summary>
        /// <param name="fileName"></param>
        static async void DownloadUri(string fileName)
        {
            //Instance of Http client
            HttpClient client = new HttpClient();
            //Send request async
            HttpResponseMessage response = await client.GetAsync(webAddress);
            //Check if response is successful or not
            response.EnsureSuccessStatusCode();
            //Save file to local
            using(FileStream fs =new FileStream(fileName,FileMode.Create,FileAccess.Write,FileShare.None))
            {
                await response.Content.CopyToAsync(fs);
            }
            Console.WriteLine("Finished");

        }
    }
}
