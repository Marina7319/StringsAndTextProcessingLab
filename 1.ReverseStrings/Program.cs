using System;
using System.Linq;
using System.Collections.Generic;
namespace ReverseStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            List<string> result = new List<string>();
            List<string> inputLine = new List<string>();
            while (command != "end")
            {
                string input = command;
                inputLine.Add(input);
                int wordLength = input.Length;
                string inputToList = "";
                for (int i = wordLength - 1; i >= 0; i--)
                {
                    inputToList += input[i];
                }
                result.Add(inputToList);
                command = Console.ReadLine();
            }
            for (int results = 0; results < result.Count; results++)
            {
                Console.WriteLine($"{inputLine[results]} = {result[results]}");
            }
        }
    }
}
