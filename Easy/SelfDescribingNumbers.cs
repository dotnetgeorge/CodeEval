using System;
using System.IO;
using System.Collections.Generic;

class SelfDescribingNumbers
{
    static void Main(string[] args)
    {
        StreamReader reader = new StreamReader("test.txt");
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


    }
}