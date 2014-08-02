using System;
using System.IO;
using System.Collections.Generic;

class FizzBuzz
{
    static void Main(string[] args)
    {
        StreamReader reader = new StreamReader(args[0]);
        List<string> lines = new List<string>();
        List<string> results = new List<string>();
        string result = "";
        char[] separator = new char[] { ' ' };

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
            string[] numbersFromLine = lines[i].Split(separator, StringSplitOptions.RemoveEmptyEntries);

            int firstDivide = Convert.ToInt32(numbersFromLine[0]);
            int secondDivide = Convert.ToInt32(numbersFromLine[1]);
            int loop = Convert.ToInt32(numbersFromLine[2]);

            for (int j = 1; j <= loop; j++)
            {
                if ((j % firstDivide) == 0 && (j % secondDivide) == 0)
                {
                    result += "FB ";
                }
                else if ((j % firstDivide) == 0)
                {
                    result += "F ";
                }
                else if ((j % secondDivide) == 0)
                {
                    result += "B ";
                }
                else
                {
                    result += j + " ";
                }
            }

            results.Add(result);
            result = "";
        }

        foreach (var item in results)
        {
            Console.WriteLine(item);
        }
    }
}