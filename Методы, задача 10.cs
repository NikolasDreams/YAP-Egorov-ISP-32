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
            int[] mass1 = {1,2,3,4,5,6,7 };
            int[] mass2 = {1,2,3,4,5,6,};
            ArraySum(mass1, mass2);
        }

        static void ArraySum(int[] mass1, int[] mass2)
        {
            int a = mass1.Length;
            int b = mass2.Length;
            if (a>=b)
            {
                int[] massSumma = new int[mass1.Length];
                massSumma = mass1;
                for (int i = 0; i < mass2.Length; i++)
                {
                    massSumma[i] += mass2[i];

                }
                for (int i = 0; i < massSumma.Length; i++)
                {

                    Console.WriteLine(massSumma[i] + " ");
                }
            }
            else
            {
                int[] massSumma = new int[mass2.Length];
                massSumma = mass2;
                for (int i = 0; i < mass1.Length; i++)
                {
                    massSumma[i] += mass1[i];
                }
                for (int i = 0; i < massSumma.Length; i++)
                {
                    Console.WriteLine(massSumma[i] + " ");
                }
            }
        }
    }
}

