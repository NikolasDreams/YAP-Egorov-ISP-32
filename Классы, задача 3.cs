using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class XYZ
    {
        public double xM;
        public double yM;
        public double zM;
        public double xP;
        public double yP;
        public double zP;

        public void Prymaiy()
        {
            double d = Math.Sqrt((xP - xM )* (xP - xM) + (yP - yM)*(yP - yM) + (zP - zM)*(zP - zM));
            Console.WriteLine(Math.Round(d, 5));
        }
        public void Verticalno()
        {
            double t = Math.Sqrt((xP - xM) * (xP - xM) + (yP - yM) * (yP - yM));
            Console.WriteLine(Math.Round(t, 5));
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            XYZ tochka = new XYZ();
            Console.WriteLine("координаты мухи");
            Console.Write("x=");
            tochka.xM = double.Parse(Console.ReadLine());
            Console.Write("y=");
            tochka.yM = double.Parse(Console.ReadLine());
            Console.Write("z=");
            tochka.zM = double.Parse(Console.ReadLine());
            Console.WriteLine("координаты поука");
            Console.Write("x=");
            tochka.xP = double.Parse(Console.ReadLine());
            Console.Write("y=");
            tochka.yP = double.Parse(Console.ReadLine());
            Console.Write("z=");
            tochka.zP = double.Parse(Console.ReadLine());
            if (tochka.yM <= 0)
            {
                tochka.Prymaiy();
                tochka.Verticalno();
            }
            else
            {
                Console.WriteLine("муха не на полу");
            }

        }
    }
}
