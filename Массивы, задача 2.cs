using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            int c =0;
            //string b = Console.ReadLine();
            for(int i=0; i<a.Length ; i++)
            {
                if (a[i] == b[i])
                {
                    c++;
                }

            }
            Console.WriteLine("Совпадение {0} элементов", c );

        }
    }
}
