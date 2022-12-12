using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Date
    {
       

      public  Date(int day, int month, int year){
            Console.WriteLine(day+"."+month+"."+year);
            
        }


        public void Next(int day, int month, int year)
        {

            if (month==1 || month==3 || month==5 || month==7 || month==8 || month==10 || month==12) {
                if (day < 31) {
                    day = day + 1;
                    Console.WriteLine(day + "." + month+ "."+year);}
                if (day == 31){
                    day = day + 1;
                    Console.WriteLine("1."+month);}
            }
            if (month == 4 || month == 6 || month == 9 || month == 11)
            {
                if (day < 30){
                    day = day + 1;
                    Console.WriteLine(day+"."+ month);}
                if (day == 31){
                    day += 1;
                    Console.WriteLine("1."+month);}
            }
            if (month == 2)
            {
                if (day < 28){
                    day = day + 1;
                    Console.WriteLine(day + "." + month);}
                if (day == 31){
                    day = day + 1;
                    Console.WriteLine("1." + month);}
            }
        }


       public void Previous(int day, int month, int year){

            if (day >1 )
                {
                day =day- 1;
                    Console.WriteLine(day + "." + month);
                }
                if (month == 1 || month == 4 || month == 6 || month == 8 || month == 9 || month == 11 || month == 12)
                {
                    month = month - 1;
                    Console.WriteLine( "31."+month);
                }
                if (month == 2 || month == 5 || month == 6 || month == 7)
                {
                month = month - 1;
                Console.WriteLine("30." + month);
                }
                if (month == 3)
                {
                    Console.WriteLine("28.02");
                }
          }
       public void Print(int day, int month, int year)
        {
            Math.Abs(day); Math.Abs(month); Math.Abs(year);

            double mez;
            mez = month % 12;
            double den = day % 31;
            den = day % 31;
            switch (mez)
            {
               
                case 1:
                    Console.WriteLine("The "+den+ " of January "+year);
                    break;
                case 2:
                    Console.WriteLine("The " + den + " of February " + year);
                    break;
                case 3:
                    Console.WriteLine("The " + den + " of March " + year);
                    break;
                case 4:
                    Console.WriteLine("The " + den + " of April " + year);
                    break;
                case 5:
                    Console.WriteLine("The " + den + " of May " + year);
                    break;
                case 6:
                    Console.WriteLine("The " + den + " of June " + year);
                    break;
                case 7:
                    Console.WriteLine("The " + den + " of July " + year);
                    break;
                case 8:
                    Console.WriteLine("The " + den + " of August " + year);
                    break;
                case 9:
                    Console.WriteLine("The " + den + " of September " + year);
                    break;
                case 10:
                    Console.WriteLine("The " + den + " of October " + year);
                    break;
                case 11:
                    Console.WriteLine("The " + den + " of November " + year);
                    break;
                case 0:
                    Console.WriteLine("The " + den + " of December " + year);
                    break;
            }
        }

       public void PrintForward(int n)
        {
            int i = n;
            while (n >= 0)
            {
                Console.WriteLine(i);
                i++;
                n--;

            }
        
        }
        public void PrintBackward(int n)
        {
            int i = n;
            while (n > 0)
            {
                Console.WriteLine(i);
                i--;
                n--;

            }

        }

        
    }
    class Program
    {
        public static void Main()
        {
            var date = new Date(12,12,2002);

            date.Next(12,9,2000);
            date.Previous(25,7,1999);
            date.Print(2,3,2);

            int n = int.Parse(Console.ReadLine());
            date.PrintForward(n);
            date.PrintBackward(n);

        }
    }
}
