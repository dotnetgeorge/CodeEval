using System;
using System.IO;
using System.Collections.Generic;

class SwapElements
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
            string[] splitLine = lines[i].Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries);
            string[] numbers = splitLine[0].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            splitLine[1].Replace(" ", "");
            string[] swapElements = splitLine[1].Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

            for (int j = 0; j < swapElements.Length; j++)
            {
                string[] indexes = swapElements[j].Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries);
                int firstIndex = Convert.ToInt32(indexes[0]);
                int secondIndex = Convert.ToInt32(indexes[1]);

                string temp = numbers[firstIndex];
                numbers[firstIndex] = numbers[secondIndex];
                numbers[secondIndex] = temp;
            }

            foreach (var item in numbers)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}