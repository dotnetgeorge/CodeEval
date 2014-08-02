using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

class SetIntersection
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

        for (int i = 0; i < lines.Count; i++)
        {
            int number = 0, index = 0;
            string[] splitLine = lines[i].Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
            List<int> firstNumbers = splitLine[0].Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries).Select(Int32.Parse).ToList();
            List<int> secondNumbers = splitLine[1].Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries).Select(Int32.Parse).ToList();
            List<int> result = new List<int>();

            if(firstNumbers.Count > secondNumbers.Count)
            {
                for (int j = 0; j < secondNumbers.Count; j++)
                {
                    if(firstNumbers.Contains(secondNumbers[j]))
                    {
                        result.Add(secondNumbers[j]);
                    }
                }
            }
            else
            {
                for (int k = 0; k < firstNumbers.Count; k++)
                {
                    if(secondNumbers.Contains(firstNumbers[k]))
                    {
                        result.Add(firstNumbers[k]);
                    }
                }
            }

            if (result.Count != 0)
            {
                if(result.Count != 1)
                {
                    for (int l = 0; l < result.Count - 1; l++)
                    {
                        Console.Write(result[l] + ",");
                    }
                    Console.WriteLine(result[result.Count - 1]);
                }
                else
                {
                    Console.WriteLine(result[0]);
                }
            }
            else
            {
                Console.WriteLine();
            }
            
        }
    }
}