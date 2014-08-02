using System;
using System.IO;

class SumOfIntegers
{
    static void Main(string[] args)
    {
        int sum = 0;
        using (StreamReader reader = new StreamReader(args[0]))
        {
            string line = reader.ReadLine();

            while (line != null)
            {
                sum += Convert.ToInt32(line);
                line = reader.ReadLine();
            }
        }

        Console.WriteLine(sum);
    }
}