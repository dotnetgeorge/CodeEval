using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

class SwapCase
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
            for (int i = 0; i < item.Length; i++)
            {
                if (Char.IsUpper(item[i]))
                {
                    string lower = item[i].ToString().ToLower();
                    Console.Write(lower);
                }
                else if (Char.IsLower(item[i]))
                {
                    string upper = item[i].ToString().ToUpper();
                    Console.Write(upper);
                }
                else
                {
                    Console.Write(item[i]);
                }
            }
            Console.WriteLine();
        }
    }
}