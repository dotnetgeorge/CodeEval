using System;
using System.IO;
using System.Collections.Generic;

class CapitalizeWords
{
    static void Main(string[] args)
    {
        StreamReader reader = new StreamReader(args[0]);
        List<string> lines = new List<string>();

        using (reader)
        {
            string line = reader.ReadLine();

            while (line != null)
            {
                lines.Add(line);
                line = reader.ReadLine();
            }
        }

        char[] separator = new char[] { ' ' };

        foreach (var item in lines)
        {
            string[] words = item.Split(separator, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < words.Length; i++)
            {
                string word = words[i];
                for (int j = 0; j < word.Length; j++)
                {
                    if (j == 0)
                    {
                        Console.Write(word[j].ToString().ToUpper());
                    }
                    else
                    {
                        Console.Write(word[j]);
                    }
                }
                Console.Write(" ");
                if (i == words.Length - 1)
                {
                    Console.WriteLine();
                }
            }
        }
    }
}