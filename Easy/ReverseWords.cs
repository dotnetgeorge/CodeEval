//Sample code to read in test cases:
using System.IO;
using System.Collections.Generic;

class ReverseWords
{
    static void Main(string[] args)
    {
        List<string> file = new List<string>();

        using (StreamReader reader = new StreamReader(args[0]))
        {
            string line = reader.ReadLine();

            while (line != null)
            {
                file.Add(line);
                line = reader.ReadLine();
            }
        }

        char[] separator = new char[] {' '};

        for (int i = 0; i < file.Count; i++)
        {
            string[] words = file[i].Split(separator, System.StringSplitOptions.RemoveEmptyEntries);
            for (int j = words.Length - 1; j >= 0; j--)
            {
                System.Console.Write(words[j] + " ");
            }
            System.Console.WriteLine();
        }
    }
}