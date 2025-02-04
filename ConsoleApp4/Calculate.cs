using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Calculate
    {
        public double numA;
        public double numB;
        public double rez;

        public Calculate() { }

        public Calculate(double numA)
        {
            this.numA = numA;
        }

        public Calculate(double numA, double numB) : this(numA)
        {
            this.numB = numB;
        }

        public double CalcSQRT()
        {
            return Math.Sqrt(numA * numB);
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Первое число: {numA}\t Второе число: {numB}\t Результат: {CalcSQRT():f2}");
        }

        public string Tostring()
        {
            return $"Первое число: {numA}\t Второе число: {numB}\t Результат: {CalcSQRT():f2}";
        }
    }

}
