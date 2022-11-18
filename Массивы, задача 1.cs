using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            string[] words = Console.ReadLine().Split().Select(x => x).ToArray();
            foreach (string word in words) // только для массивов 
            {
                foreach (char letter in word)
                    Console.WriteLine(letter);
                Console.WriteLine();
            }
        }
    }
}