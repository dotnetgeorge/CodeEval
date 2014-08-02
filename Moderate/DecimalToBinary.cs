using System;
using System.Collections.Generic;
using System.IO;

class DecimalToBinary
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

        int length = lines.Count;

        for (int i = 0; i < length; i++)
        {
            int number = Convert.ToInt32(lines[i]);
            string binary = Convert.ToString(number, 2);

            Console.WriteLine(binary);
        }
    }
}