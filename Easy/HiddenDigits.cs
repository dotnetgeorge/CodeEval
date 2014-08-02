using System;
using System.IO;
using System.Collections.Generic;

class HiddenDigits
{
    static void Main(string[] args)
    {
        StreamReader reader = new StreamReader(args[0]);
        List<string> lines = new List<string>();
        string result = "";

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
            string message = lines[i];

            for (int j = 0; j < message.Length; j++)
            {
                if(Char.IsDigit(message[j]))
                {
                    result += message[j];
                }
                switch (message[j])
                {
                    case 'a':
                        result += "0";
                        break;
                    case 'b':
                        result += "1";
                        break;
                    case 'c':
                        result += "2";
                        break;
                    case 'd':
                        result += "3";
                        break;
                    case 'e':
                        result += "4";
                        break;
                    case 'f':
                        result += "5";
                        break;
                    case 'g':
                        result += "6";
                        break;
                    case 'h':
                        result += "7";
                        break;
                    case 'i':
                        result += "8";
                        break;
                    case 'j':
                        result += "9";
                        break;
                }
            }
            Console.WriteLine(result == String.Empty ? "NONE" : result);
            result = "";
        }
    }
}