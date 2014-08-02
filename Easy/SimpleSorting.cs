using System;
using System.IO;
using System.Collections.Generic;
using System.Globalization;

class SimpleSorting
{
    static void Main(string[] args)
    {
        StreamReader reader = new StreamReader(args[0]);
        List<string> lines = new List<string>();
        List<double> numbers = new List<double>();
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

            for (int j = 0; j < numbersFromLine.Length; j++)
            {
                double convert = Convert.ToDouble(numbersFromLine[j], CultureInfo.InvariantCulture.NumberFormat);

                numbers.Add(convert);
            }

            numbers.Sort();

            foreach (var number in numbers)
            {
                Console.Write("{0:F3} ", number);            }
            Console.WriteLine();
            numbers = new List<double>();
        }
    }
}