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
         int startValue = int.Parse(Console.ReadLine());
         int endValue = int.Parse(Console.ReadLine());
         PrintSum(GetCubes(startValue, endValue));               
        }
        static int[] PrintSum(int[] arr)
        {
            int raz = arr.Length, summa = 0;
            for (int i = 0; i < raz; i++)
            {
                summa += arr[i];
            }
            Console.WriteLine(summa);
            return arr;
        }
        static int[] GetCubes(int startValue, int endValue)
        {
            int d = 1 + endValue - startValue;
            int[] arr = new int[d];
            int r = startValue;
            for (int i = 0; i < d; i++)
            {
                arr[i] = r;
                r++;
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
            return arr;
        }
    }
}

