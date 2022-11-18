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
        {int d, c,e;
            Console.Write("число a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("число b: ");
            int b = int.Parse(Console.ReadLine());
            int r = (int)Math.Log10(b) + 1;
            c = b;
            d = a;
           int[] m= new int[r];
            for(int i = 0; i < r; i++) 
            {
                e = c % 10;
                m[i] =e ;
                c = c / 10;
            }
            while (a > 0)
            {
                d = a % 10;
                a = a / 10;              
                for (int i = 0; i < r; i++)
                {
                    if (m[i]==d)
                    {
                        Console.Write(d+" ");
                    }
                }
            }
        }
     }
}