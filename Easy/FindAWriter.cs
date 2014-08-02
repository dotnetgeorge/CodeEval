using System;
using System.IO;
using System.Collections.Generic;

class FindAWriter
{
    static void Main(string[] args)
    {
        StreamReader reader = new StreamReader(args[0]);
        List<string> lines = new List<string>();
        List<string> writers = new List<string>();
        char[] separator = new char[] { ' ' };
        string writer = "";

        using (reader)
        {
            string line = reader.ReadLine();

            while (line != null)
            {
                if (line != String.Empty)
                {
                    lines.Add(line);
                }
                line = reader.ReadLine();
            }
        }

        for (int i = 0; i < lines.Count; i++)
        {
            int indexPipe = lines[i].IndexOf("|");
            string encodedWriter = lines[i].Substring(0, indexPipe);
            string numbersInLine = lines[i].Substring(indexPipe + 1);
            string[] numbers = numbersInLine.Split(separator, StringSplitOptions.RemoveEmptyEntries);
            List<int> indexes = new List<int>();

            for (int k = 0; k < numbers.Length; k++)
			{
                indexes.Add(Convert.ToInt32(numbers[k]));
			}


            for (int j = 0; j < indexes.Count; j++)
            {
                int position = indexes[j] - 1;
                if (position < encodedWriter.Length)
                {
                    writer += encodedWriter[position];
                }
            }

            writers.Add(writer);
            writer = "";
        }

        foreach (var item in writers)
        {
            Console.WriteLine(item);
        }
    }
}