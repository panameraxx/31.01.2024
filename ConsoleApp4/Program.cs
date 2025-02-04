using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculate c1 = new Calculate();
            c1.numA = 10;
            c1.numB = 2;
            c1.ShowInfo();

            Calculate c2 = new Calculate(15, 2);
            Console.WriteLine($"{c2.Tostring()}");

            Console.WriteLine("Введите первое число: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число: ");
            double b = double.Parse(Console.ReadLine());

            Calculate c3 = new Calculate(a, b);
            Console.WriteLine($"{c3.Tostring()}");

            Console.ReadKey();

        }
    }
}
