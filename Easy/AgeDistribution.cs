using System;
using System.IO;
using System.Collections.Generic;

class AgeDistribution
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
            int age = Convert.ToInt32(lines[i]);

            if(0 <= age && age <= 2)
            {
                Console.WriteLine("Still in Mama's arms");
            }
            else if(3 <= age && age <= 4)
            {
                Console.WriteLine("Preschool Maniac");
            }
            else if(5 <= age && age <= 11)
            {
                Console.WriteLine("Elementary school");
            }
            else if(12 <= age && age <= 14)
            {
                Console.WriteLine("Middle school");
            }
            else if(15 <= age && age <= 18)
            {
                Console.WriteLine("High school");
            }
            else if(19 <= age && age <= 22)
            {
                Console.WriteLine("College");
            }
            else if(23 <= age && age <= 65)
            {
                Console.WriteLine("Working for the man");
            }
            else if(66 <= age && age <= 100)
            {
                Console.WriteLine("The Golden Years");
            }
            else
            {
                Console.WriteLine("This program is for humans");
            }
        }
    }
}