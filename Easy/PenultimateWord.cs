using System;
using System.IO;
using System.Collections.Generic;

class PenultimateWord
{
    static void Main(string[] args)
    {
        StreamReader reader = new StreamReader(args[0]);
        List<string> lines = new List<string>();
        char[] separator = new char[] { ' ', ',', '.', '!', '?' };

        using (reader)
        {
            string line = reader.ReadLine();

            while (line != null)
            {
                lines.Add(line);
                line = reader.ReadLine();
            }
        }

        for (int i = 0; i < lines.Count; i++)
        {
            string[] separatedWords = lines[i].Split(separator, StringSplitOptions.RemoveEmptyEntries);

            Array.Reverse(separatedWords);

            Console.WriteLine(separatedWords[1]);
        }
    }
}