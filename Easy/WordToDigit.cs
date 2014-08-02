using System;
using System.IO;
using System.Collections.Generic;

class WordToDigit
{
    static void Main(string[] args)
    {
        StreamReader reader = new StreamReader(args[0]);
        List<string> lines = new List<string>();
        List<string> digits = new List<string>();
        string[] digitsFromLine;
        char[] separator = new char[] { ';' };
        string result = "";

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
            digitsFromLine = lines[i].Split(separator, StringSplitOptions.RemoveEmptyEntries);

            for (int j = 0; j < digitsFromLine.Length; j++)
            {
                switch (digitsFromLine[j])
                {
                    case "zero":
                        result += "0";
                        break;
                    case "one":
                        result += "1";
                        break;
                    case "two":
                        result += "2";
                        break;
                    case "three":
                        result += "3";
                        break;
                    case "four":
                        result += "4";
                        break;
                    case "five":
                        result += "5";
                        break;
                    case "six":
                        result += "6";
                        break;
                    case "seven":
                        result += "7";
                        break;
                    case "eight":
                        result += "8";
                        break;
                    case "nine":
                        result += "9";
                        break;
                }
            }

            digits.Add(result);
            result = "";
        }

        foreach (var item in digits)
        {
            Console.WriteLine(item);
        }
    }
}