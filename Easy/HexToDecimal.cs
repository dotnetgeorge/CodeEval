using System;
using System.IO;
using System.Collections.Generic;

class HexToDecimal
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

        foreach (var item in lines)
	    {
            int number = Convert.ToInt32(item, 16);
            Console.WriteLine(number);
	    }
    }
}