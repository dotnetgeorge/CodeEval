using System;
using System.IO;
using System.Collections.Generic;


class NmodM
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

        char[] separator = new char[] { ',' };

        foreach (var item in lines)
        {
            string[] numbers = item.Split(separator, StringSplitOptions.RemoveEmptyEntries);

            int sum = Convert.ToInt32(numbers[0]) % Convert.ToInt32(numbers[1]);

            Console.WriteLine(sum);
        }
    }
}