using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Tree{
     public Tree(string trees, int tempe){
            if(tempe<=60){
                Console.WriteLine("В бане холодно");}
            if (60<=tempe && tempe<=90){
                Console.WriteLine("В бане комфортная температура");}
            if (tempe >= 90){
                Console.WriteLine("В бане жарко");}

     
            if (trees=="сосна"){
                Console.WriteLine("плохой веник");}
            if (trees == "береза"){
                Console.WriteLine("хороший веник");}
            if (trees == "дуб"){
                Console.WriteLine("отличный веник");}
        }
    }
    class Program
    {
        public static void Main()
        {
            var tree1 = new Tree("сосна", -6);
            var tree2 = new Tree("береза", 80);
        }
    }
}
