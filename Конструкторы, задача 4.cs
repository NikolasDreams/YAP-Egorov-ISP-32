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
        public Money �;

        public Money(string nominal, string quantity)
        {
            int x = Convert.ToInt32(quantity);
            if (x >= 0)
            {
                if (nominal == "���.")
                {
                    if (x > 99)
                    {
                        int z = x / 100;
                        int y = x % 100;
                        Console.WriteLine(z + " �. "  + y + nominal);
                    }
                }
                if (nominal == "�.")
                {
                    Console.WriteLine(quantity + nominal);
                }
            }
            else
            {
                Console.WriteLine("�� ����� ���� �������������!");
            }

        }
        public money(string quantity , string nominal, string quantity1, string nominal1)
        {

            int x = Convert.ToInt32(quantity1);
            if (x >= 0){

                if (nominal == "���."){
                    Console.WriteLine("����� � ������� ���������� �������!");
                }
                if(nominal == "�."){
                    if (x > 99){
                        int z = x / 100;
                        int y = x % 100;
                        x += z;
                        Console.WriteLine(x + nominal + y +nominal1);
                    }
                }
               
            }

            else{
                Console.WriteLine("�� ����� ���� �������������!");
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

