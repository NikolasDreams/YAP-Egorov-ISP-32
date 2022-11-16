using System;
using System.Linq;

namespace ProgLang
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите массив: ");
            double[] m = Console.ReadLine().Split(' ').Select(b => double.Parse(b)).ToArray();
            Console.Write("Введите число x: ");
            double x = double.Parse(Console.ReadLine());

            Array.Sort(m);
            Console.WriteLine();
            for (int i = 0; i < m.Length; i++)
            {
                if (m[i] % 2 != 0 && m[i] < x)
                {
                    Console.Write(m[i] + " ");
                }
            }
            
            for (int i = 0; i < m.Length; i++)
            {
                string w = (m[i]).ToString();
                if (m[i] % 2 == 0 && w.EndsWith('0') || w.EndsWith('2') || w.EndsWith('4') || w.EndsWith('6') || w.EndsWith('8'))
                {
                    Console.Write(m[i] + " ");
                }
            }
            
        }
    }
}
