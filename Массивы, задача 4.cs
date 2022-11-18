using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            int a = 0, b = 0, c = 0, d = 0;
            string[] s = Console.ReadLine().Split(',').Select(n => n).ToArray();
            for (int i = 0; i < s.Length; i++)
            {
               
                if (s[i] == "2")
                    a++;
                if (s[i] == "3")
                {
                    b++;
                }
                if ( s[i] == "4"  )
                {
                    c++;
                }
                if ( s[i] == "5")
                {
                    d++;
                }
            }
           
            for (int i = 0; i < 1; i++) { 
                    if (a > 0)
                    {
                        Console.WriteLine("Ну что, студент, пора долг Родине отдать");
                        break;
                    }
                    if (b > 0)
                    {
                        Console.WriteLine("Прощай стипендия!");
                        break;
                    }
                    if (a <= 0 && a <= 0 && d != 4)
                    {
                        Console.WriteLine("Живи пока, через полгода увидимся");
                    break;
                }
                    if (d == 4)
                    {

                        Console.WriteLine("О, отличник появился! На олимпиаду пойдешь");
                    break;
                }
            }
            

           
        }
    }
}