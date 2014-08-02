using System;
using System.IO;
using System.Collections.Generic;

class MultiplyLists
{
    static void Main(string[] args)
    {
        StreamReader reader = new StreamReader(args[0]);
        List<string> lines = new List<string>();
        List<int> firstList = new List<int>();
        List<int> secondList = new List<int>();

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
            int number = 0;
            string[] lists = lines[i].Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);

            string[] splitFirstList = lists[0].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string[] splitSecondList = lists[1].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var item in splitFirstList)
            {
                number = Convert.ToInt32(item);
                firstList.Add(number);
            }

            foreach (var item in splitSecondList)
            {
                number = Convert.ToInt32(item);
                secondList.Add(number);
            }

            for (int j = 0; j < firstList.Count; j++)
            {
                int multiply = firstList[j] * secondList[j];
                Console.Write(multiply + " ");
            }
            Console.WriteLine();
            firstList = new List<int>();
            secondList = new List<int>();
        }
    }
}