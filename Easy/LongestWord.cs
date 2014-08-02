using System;
using System.IO;
using System.Collections.Generic;

class LongestWord
{
    static void Main(string[] args)
    {
        StreamReader reader = new StreamReader(args[0]);
        List<string> lines = new List<string>();
        char[] separator = new char[] { ' ' };
        int length = 0, biggestLength = 0;
        string bestWord = "";

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
            string[] separatedWord = lines[i].Split(separator, StringSplitOptions.RemoveEmptyEntries);

            for (int j = 0; j < separatedWord.Length; j++)
            {
                length = separatedWord[j].Length;
                
                if(length > biggestLength)
                {
                    biggestLength = length;
                    bestWord = separatedWord[j];
                }
            }

            Console.WriteLine(bestWord);

            length = 0;
            biggestLength = 0;
        }
    }
}