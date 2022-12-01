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
            int n = int.Parse(Console.ReadLine());
            int[] mass = new int[n];
            for(int i=0; i<n; i++)
            {
                 mass[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (mass[j] > mass[j + 1])
                    {
                        int temp = mass[j];
                        mass[j] = mass[j + 1];
                        mass[j + 1] = temp;
                        
                    }
                   

                }
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write(mass[i]+" ");
            }
        }
    }
}
