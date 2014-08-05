using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        StreamReader reader = new StreamReader(args[0]);
        List<string> lines = new List<string>();
        string word = null;
        string shortWord = null;
        int countOfShortWord = 1;

        using (reader)
        {
            string line = reader.ReadLine();

            while (line != null)
            {
                lines.Add(line);
                line = reader.ReadLine();
            }
        }

        int length = lines.Count;

        for (int i = 0; i < length; i++)
        {
            word = lines[i];
            shortWord = ShortWord(word);
            countOfShortWord = CountOfShortWord(word, shortWord);

            if (countOfShortWord == 1)
            {
                Console.WriteLine(word.Length);
            }
            else
            {
                Console.WriteLine(shortWord.Length);
            }
        }
    }

    public static string ShortWord(string word)
    {
        string shortWord = "";
        int length = word.Length;

        for (int i = 0; i < length; i++)
        {
            if(!shortWord.Contains(word[i]))
            {
                shortWord += word[i];
            }
            else
            {
                break;
            }
        }

        return shortWord;
    }

    public static int CountOfShortWord(string word, string shortWord)
    {
        int countOfShortWord = Regex.Matches(word, shortWord).Count;

        return countOfShortWord;
    }
}