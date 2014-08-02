using System;
using System.IO;
using System.Collections.Generic;

class LettercasePercentageRatio
{
    static void Main(string[] args)
    {
        StreamReader reader = new StreamReader(args[0]);
        List<string> lines = new List<string>();
        List<string> results = new List<string>();
        int lowerCaseCount = 0, upperCaseCount = 0;

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
            string textFromLine = lines[i];

            for (int j = 0; j < textFromLine.Length; j++)
            {
                if(Char.IsLower(textFromLine[j]))
                {
                    lowerCaseCount++;
                }
                else if(Char.IsUpper(textFromLine[j]))
                {
                    upperCaseCount++;
                }
            }

            float lowerPercentage = ((100f * lowerCaseCount) / textFromLine.Length);
            float upperPercentage = ((100f * upperCaseCount) / textFromLine.Length);

            string result = String.Format("lowercase: {0:0.00} uppercase: {1:0.00}", lowerPercentage, upperPercentage);
            results.Add(result);

            lowerCaseCount = 0;
            upperCaseCount = 0;
        }

        foreach (var item in results)
        {
            Console.WriteLine(item);
        }
    }
}