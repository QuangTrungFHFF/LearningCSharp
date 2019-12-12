using System;

namespace ReadIntergerFromTextFile
{
    
    public class FileParseException : Exception
    {
        public string FileName { get; }
        public int Row { get;  }
        public FileParseException()
        {
        }

        public FileParseException(string message) : base(message)
        {
        }
        public FileParseException(string message, Exception inner):base(message,inner)
        {

        }
        public FileParseException(string message, string fileName, int row):this(message)
        {
            FileName = fileName;
            Row = row;
        }
    }
}