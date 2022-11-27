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
            var test = new List<int> {1,4,6,7,8,9,12,13,14};
            int a = test[0]-1;
            int b = 1, c=0;
            for (var i = 0; i < test.Count; i++)
            {
                b++;
               
            }
           
            for (var i = a; i <b; i++)
            {
                c = test[i]+1;
                if (test[i + 1]!=c)
                {
                    while (test[i + 1] != c)
                    {
                       
                        Console.WriteLine(c + " ");
                        c++;
                    }

                }
               
               

            }
        }

        
    }
}
//Console.WriteLine(c);
