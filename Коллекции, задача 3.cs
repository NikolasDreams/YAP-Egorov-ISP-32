using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {

            var number = new List<int>();
            Random rand = new Random();
            for (int i = 0; i < 10; i++)
            {
                number.Add(rand.Next(-10000, 10000));
            }
            Console.WriteLine(string.Join(" ", number));


        }
    }
}

