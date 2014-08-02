using System;

class SumOfPrimes
{
    static void Main(string[] args)
    {
        int countOfPrimes = 0, index = 2, sumOfPrimes = 0;

        while (countOfPrimes != 1000)
        {
            if(IsPrime(index))
            {
                countOfPrimes++;
                sumOfPrimes += index;
            }

            index++;
        }

        Console.WriteLine(sumOfPrimes);
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