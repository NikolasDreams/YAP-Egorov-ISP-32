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
                Console.WriteLine("� ���� �������");}
            if (60<=tempe && tempe<=90){
                Console.WriteLine("� ���� ���������� �����������");}
            if (tempe >= 90){
                Console.WriteLine("� ���� �����");}

     
            if (trees=="�����"){
                Console.WriteLine("������ �����");}
            if (trees == "������"){
                Console.WriteLine("������� �����");}
            if (trees == "���"){
                Console.WriteLine("�������� �����");}
        }
    }
    class Program
    {
        public static void Main()
        {
            var tree1 = new Tree("�����", -6);
            var tree2 = new Tree("������", 80);
        }
    }
}
