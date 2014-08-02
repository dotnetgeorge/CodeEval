using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

class CountingPrimes
{
    static void Main(string[] args)
    {
        StreamReader reader = new StreamReader(args[0]);
        List<string> lines = new List<string>();
        List<int> numbers = new List<int>();
        char[] separator = new char[] { ',' };
        int firstNumber = 0, secondNumber = 0, countOfPrimes = 0;

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
            string split = lines[i];
            numbers = split.Split(separator, StringSplitOptions.RemoveEmptyEntries).Select(Int32.Parse).ToList();

            firstNumber = numbers[0];
            secondNumber = numbers[1];
            countOfPrimes = CountOfPrimes(firstNumber, secondNumber);

            Console.WriteLine(countOfPrimes);
        }
    }

    public static int CountOfPrimes(int startNumber, int endNumber)
    {
        int count = 0;

        for (int i = startNumber; i <= endNumber; i++)
        {
            if(IsPrime(i))
            {
                count++;
            }
        }

        return count;
    }

    public static bool IsPrime(int number)
    {
        for (int i = 2; i < (number / 2 + 1); i++)
        {
            if((number % i) == 0)
            {
                return false;
            }
        }

        return true;
    }
}