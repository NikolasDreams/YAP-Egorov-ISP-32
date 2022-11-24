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
            int number = int.Parse(Console.ReadLine());
            Factorize(number);
        }

        static void Factorize(int number)
        {
            int a;
            for (int i = 1; i < number; i++)
            {
                a = number / i;
                if (number % i == 0 && i <= a)
                {
                    Console.WriteLine(number+"="+i + "*" + a);
                }
            }
        }
    }
}

