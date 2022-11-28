using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Worker
    {
        public  string name;
        public string surname;
        public int rate;
        public int days;

     public void   GetFullName()
        {
            Console.WriteLine(name+" "+ surname);
        }
       public int GetSalary()
        {
            Console.WriteLine(rate*days);
            return rate * days;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Worker w1 = new Worker();
            w1.name = Console.ReadLine();
            w1.surname = Console.ReadLine();
            w1.rate = int.Parse(Console.ReadLine());
            w1.days =int.Parse(Console.ReadLine());
            w1.GetFullName();
            w1.GetSalary();
        }
    }
}
