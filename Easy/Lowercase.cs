using System;
using System.IO;
using System.Collections.Generic;

class Lowercase
{
    static void Main(string[] args)
    {
        List<string> lines = new List<string>();
        StreamReader reader = new StreamReader(args[0]);
        using (reader)
        {
            string line = reader.ReadLine();
            while (line != null)
            {
                lines.Add(line);
                line = reader.ReadLine();
            }
        }
        foreach (var item in lines)
        {
            Console.WriteLine(item.ToLower());
        }
    }
}