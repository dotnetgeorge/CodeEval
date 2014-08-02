using System;
using System.IO;
using System.Collections.Generic;

class RomanNumerals
{
    static void Main(string[] args)
    {
        StreamReader reader = new StreamReader(args[0]);
        List<string> lines = new List<string>();
        List<int> arabicDigits = new List<int>() 
        {
            1, 4, 5, 9, 10, 40, 50, 90, 100, 400, 500, 900, 1000
        };
        List<string> romanDigits = new List<string>() 
        {
            "I", "IV", "V", "IX", "X", "XL", "L", "XC", "C", "CD", "D", "CM", "M"
        };

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
            string result = "";

            while (number > 0)
            {
                for (int j = arabicDigits.Count - 1; j >= 0; j--)
                {
                    if((number / arabicDigits[j]) >= 1)
                    {
                        number -= arabicDigits[j];
                        result += romanDigits[j];
                        break;
                    }
                }
            }

            Console.WriteLine(result);
        }
    }
}