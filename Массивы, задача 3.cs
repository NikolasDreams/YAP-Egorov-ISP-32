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
            //Задача 3
            Console.Write("Высота елочки: ");
            int a = int.Parse(Console.ReadLine());
            int w = 0;
            for (int j = 0; j <= a; j++)
            {
                Console.WriteLine(new string(' ', a - j) + new string('*', w));
                w = j * 2 + 1;

            }
	}
    }
}
