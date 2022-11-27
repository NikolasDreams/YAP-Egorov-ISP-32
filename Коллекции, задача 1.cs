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
            var test = new List<string> {"O", "O", "O", "O", "O", "O", "Q", "O", "O" };
            for (var i = 0; i < test.Count; i++)
            {
                if(test[i]=="Q")
                Console.Write(i);
            }
        }

        
    }
}

