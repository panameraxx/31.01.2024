using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Time t1 = new Time();
            t1.h = 1;
            t1.m = 120;
            t1.s = 500;
            t1.ShowInfo();

            Time t2 = new Time(15, 25, 200);
            Console.WriteLine($"{t2.Tostring()}");

            Console.WriteLine("Введите часы: ");
            int h1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите минуты: ");
            int m1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите секунды: ");
            int s1 = int.Parse(Console.ReadLine());

            Time t3 = new Time(h1, m1, s1);
            Console.WriteLine($"{t3.Tostring()}");

            Console.ReadKey();

        }
    }
}
