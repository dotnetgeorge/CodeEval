using System;
using System.IO;
using System.Collections.Generic;

class QueryBoard
{
    static void Main(string[] args)
    {
        int[,] matrix = new int[256, 256];
        StreamReader reader = new StreamReader(args[0]);
        List<string> lines = new List<string>();
        string[] queryFromLine;
        char[] separator = new char[] { ' ' };
        int value, row, col, sum = 0;


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
            string selectedLine = lines[i];
            queryFromLine = selectedLine.Split(separator, StringSplitOptions.RemoveEmptyEntries);
            string query = queryFromLine[0];

            switch (query)
            {
                case "SetRow":
                    row = Convert.ToInt32(queryFromLine[1]);
                    value = Convert.ToInt32(queryFromLine[2]);

                    for (int cols = 0; cols < matrix.GetLength(1); cols++)
                    {
                        matrix[row, cols] = value;
                    }
                    break;
                case "SetCol":
                    col = Convert.ToInt32(queryFromLine[1]);
                    value = Convert.ToInt32(queryFromLine[2]);

                    for (int rows = 0; rows < matrix.GetLength(0); rows++)
                    {
                        matrix[rows, col] = value;
                    }
                    break;
                case "QueryRow":
                    row = Convert.ToInt32(queryFromLine[1]);

                    for (int cols = 0; cols < matrix.GetLength(1); cols++)
                    {
                        sum += matrix[row, cols];
                    }

                    Console.WriteLine(sum);
                    sum = 0;
                    break;
                case "QueryCol":
                    col = Convert.ToInt32(queryFromLine[1]);

                    for (int rows = 0; rows < matrix.GetLength(0); rows++)
                    {
                        sum += matrix[rows, col];
                    }

                    Console.WriteLine(sum);
                    sum = 0;
                    break;
                default:
                    Console.WriteLine("error!");
                    break;
            }
        }
    }
}