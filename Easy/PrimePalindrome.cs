using System;
using System.IO;
using System.Collections.Generic;

class PrimePalindrome
{
    static void Main(string[] args)
    {
        int primePalindrome = 0;

        for (int i = 999; i > 2; i--)
        {
           if(IsPrime(i) && IsPalindrome(i))
           {
               primePalindrome = i;
               break;
           }
        }

        Console.WriteLine(primePalindrome);
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

    public static bool IsPalindrome(int number)
    {
        int length = number.ToString().Length;
        string digits = number.ToString();

        for (int i = 0; i < length; i++)
        {
            if(digits[i] != digits[length - i - 1])
            {
                return false;
            }
        }

        return true;
    }
}