using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
   class  Barrel{
       public int volume;
        public string material;

    public void ToChange(string material)
        {
            switch (material)
            {
                case "beech":
                    Console.WriteLine("a barrel from africa");
                    break;
                case "oak":
                    Console.WriteLine("a barrel from russia");
                    break;
                case "iron":
                    Console.WriteLine("a barrel from europe");
                    break;

            }
        }
        public void ToChange(int volume)
        {
            int cost = volume * 500;
            Console.WriteLine(cost);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var barrel = new Barrel();
            barrel.material = "oak";
            barrel.volume = 200;
            barrel.ToChange(100);
            barrel.ToChange("beech");
            Console.WriteLine($"{barrel.material}, {barrel.volume}");
        }
    }
}
