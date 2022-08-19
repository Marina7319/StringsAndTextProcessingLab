using System;

namespace RepeatStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arrStrings = Console.ReadLine().Split();
            string result = string.Empty;
            foreach (string str in arrStrings)
            {
                for (int i = 0; i < str.Length; i++)
                {
                    result += str;
                }
            }
            Console.WriteLine(result);
        }
    }
}
