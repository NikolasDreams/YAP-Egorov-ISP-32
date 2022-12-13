using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Money
    {
        string nominal;
        string quantity;
        public int rub;
        public Money с;

        public Money(string nominal, string quantity)
        {
            int x = Convert.ToInt32(quantity);
            if (x >= 0)
            {
                if (nominal == "коп.")
                {
                    if (x > 99)
                    {
                        int z = x / 100;
                        int y = x % 100;
                        Console.WriteLine(z + " р. "  + y + nominal);
                    }
                }
                if (nominal == "р.")
                {
                    Console.WriteLine(quantity + nominal);
                }
            }
            else
            {
                Console.WriteLine("Не может быть отрицательным!");
            }

        }
        public money(string quantity , string nominal, string quantity1, string nominal1)
        {

            int x = Convert.ToInt32(quantity1);
            if (x >= 0){

                if (nominal == "коп."){
                    Console.WriteLine("Рубли и копейки перепутаны местами!");
                }
                if(nominal == "р."){
                    if (x > 99){
                        int z = x / 100;
                        int y = x % 100;
                        x += z;
                        Console.WriteLine(x + nominal + y +nominal1);
                    }
                }
               
            }

            else{
                Console.WriteLine("Не может быть отрицательным!");
            }

        }
   static int Sum(Money a, Money b) {
          
            return a.rub + b.rub;
        }
        static int Difference(Money a, Money b)
        {

            return a.rub - b.rub;
        }
     public double PrintTransferCost( double komissia)
        {
            int 

            return;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
           
        }
    }
}

