using System;

class MultiplicationTables
{
    static void Main(string[] args)
    {
        int[,] matrix = new int[12, 12];
        int index = 1;
        int addNumber = 0;

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                addNumber += index;
                matrix[row, col] = addNumber;
            }
            addNumber = 0;
            index++;
        }

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("{0,4}", matrix[row, col]);
            }
            Console.WriteLine();
        }
    }
}