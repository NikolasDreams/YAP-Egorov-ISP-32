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
                        Console.WriteLine("�� ���, �������, ���� ���� ������ ������");
                        break;
                    }
                    if (b > 0)
                    {
                        Console.WriteLine("������ ���������!");
                        break;
                    }
                    if (a <= 0 && a <= 0 && d != 4)
                    {
                        Console.WriteLine("���� ����, ����� ������� ��������");
                    break;
                }
                    if (d == 4)
                    {

                        Console.WriteLine("�, �������� ��������! �� ��������� �������");
                    break;
                }
            }
            

           
        }
    }
}