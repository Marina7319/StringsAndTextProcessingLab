using System;

namespace Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string substringToRemove = Console.ReadLine();
            string stringSubstirng = Console.ReadLine();
            int substringToRemoveLength = substringToRemove.Length;
            while (stringSubstirng.Contains(substringToRemove))
            {
                int stratIndex = stringSubstirng.IndexOf(substringToRemove);
                stringSubstirng = stringSubstirng.Remove(stratIndex, substringToRemoveLength);
            }
            Console.WriteLine(stringSubstirng);
        }
    }
}
