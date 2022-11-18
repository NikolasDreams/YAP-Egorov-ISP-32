using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        { 
Console.Write("число n: ");
            int n = int.Parse(Console.ReadLine());
            int x = 0, y = 0;
            for (int j = 0; j <= n; j++)
            {
                x = 12 + j;
                y = 5 + j * 5;

            }
            Console.WriteLine(x + ":" + y);
}
}
}