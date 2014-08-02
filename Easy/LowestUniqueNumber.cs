using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class LowestUniqueNumber
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
            List<int> beforeSort = lines[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(Int32.Parse).ToList();
            List<int> numbers = lines[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(Int32.Parse).ToList();
            int uniqueNumber = int.MinValue, position = 0;

            numbers.Sort();

            for (int j = 0; j < numbers.Count - 1; j++)
            {
                if(j == 0 && numbers[j] != numbers[j + 1])
                {
                    uniqueNumber = numbers[j];
                    break;
                }
                else
                {
                    if (j != 0)
                    {
                        if (numbers[j - 1] != numbers[j] && numbers[j] != numbers[j + 1])
                        {
                            uniqueNumber = numbers[j];
                            break;
                        }
                    }
                }
            }

            for (int k = 0; k < beforeSort.Count; k++)
            {
                if(beforeSort[k] == uniqueNumber)
                {
                    position = k + 1;
                    break;
                }
            }

            Console.WriteLine(position);
        }
    }
}