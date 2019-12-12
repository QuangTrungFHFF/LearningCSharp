using System;
using System.IO;

namespace WritingDataLib
{
    /// <summary>
    /// Writing an byte array to file
    /// </summary>
    public class WritingBytes
    {
        public static void WritingBytesArrayToFile(string fileName, byte[] byteArray)
        {
            using (BinaryWriter bw = new BinaryWriter(File.Open(fileName, FileMode.Create)))
            {
                bw.Write(byteArray, 0, byteArray.Length);
                Console.WriteLine("File {0} is successfully created at {1} ", fileName, Directory.GetCurrentDirectory());
            }
        }
    }
}
