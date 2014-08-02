using System;
using System.IO;
using System.Collections.Generic;

class ArmstrongNumbers
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
            int number = Convert.ToInt32(lines[i]);
            int loop = number;
            int length = lines[i].Length;
            int result = 0;

            while (loop > 0)
            {
                int temp = loop % 10;
                loop /= 10;
                result += (int)Math.Pow(temp, length);
            }

            Console.WriteLine(result == number ? "True" : "False");
        }
    }
}