using System;
using System.Collections.Generic;
using System.IO;

class MinimumCoins
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
            int countOfCoins = 0;

            while (number > 0)
            {
                if(number - 5 >= 0)
                {
                    countOfCoins++;
                    number -= 5;
                }
                else if(number - 3 >= 0)
                {
                    countOfCoins++;
                    number -= 3;
                }
                else if(number - 1 >= 0)
                {
                    countOfCoins++;
                    number -= 1;
                }
                else
                { }
            }

            Console.WriteLine(countOfCoins);
        }
    }
}