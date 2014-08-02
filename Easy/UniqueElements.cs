using System;
using System.IO;
using System.Collections.Generic;

class UniqueElements
{
    static void Main(string[] args)
    {
        StreamReader reader = new StreamReader(args[0]);
        List<string> lines = new List<string>();
        List<int> numbers = new List<int>();
        List<string> uniqueNumbers = new List<string>();
        string result = "";
        char[] separator = new char[] { ',' };
        string[] numbersFromLine;

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
            numbersFromLine = lines[i].Split(separator, StringSplitOptions.RemoveEmptyEntries);

            for (int j = 0; j < numbersFromLine.Length; j++)
            {
                int number = Convert.ToInt32(numbersFromLine[j]);
                numbers.Add(number);
            }

            numbers.Sort();

            for (int k = 0; k < numbers.Count - 1; k++)
            {
                if (numbers[k] + 1 == numbers[k + 1])
                {
                    result += numbers[k] + ",";
                }
            }

            result += numbers[numbers.Count - 1];
            uniqueNumbers.Add(result);

            numbers = new List<int>();
            result = "";
        }

        foreach (var key in uniqueNumbers)
        {
            Console.WriteLine(key);
        }
    }
}