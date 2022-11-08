using System;
using System.Linq;

namespace ProgLang
{
    class Program
    {
        static void Main()
        {
            double[] h = Console.ReadLine().Split(' ').Select(x => double.Parse(x)).ToArray();
            double v = double.Parse(Console.ReadLine());

            Array.Sort(h);
            for (int i = 0; i < h.Length; i++)
            {
                string g = (h[i]).ToString();
                if (h[i] % 2 == 0 && g.EndsWith('0') || g.EndsWith('2') || g.EndsWith('4') || g.EndsWith('6') || g.EndsWith('8'))
                {
                    Console.Write(h[i] + " ");
                }
            }
            Console.WriteLine();
            for (int i = 0; i < h.Length; i++)
            {
                if (h[i] % 2 != 0 && h[i] < v)
                {
                    Console.Write(h[i] + " ");
                }
            }
        }
    }
}