using System;
using System.IO;

class FileSize
{
    static void Main(string[] args)
    {
        FileInfo fileInfo = new FileInfo(args[0]);

        long fileSize = fileInfo.Length;

        Console.WriteLine(fileSize);
    }
}