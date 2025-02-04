using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Time
    {
        public int h;
        public int m;
        public int s;

        public Time() { }

        public Time(int h)
        {
            this.h = h;
        }

        public Time(int h, int m) : this(h)
        {
            this.m = m;
        }

        public Time(int h, int m, int s) : this(h, m)
        {
            this.s = s;
        }

        public int Timeins()
        {
            int rez = h * 60;
            int rez2 = rez + m;
            return rez2 * 60 + s;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Часы: {h}\t Минуты: {m}\t Секунды: {s}\t Результат: {Timeins()} секунд");
        }

        public string Tostring()
        {
            return $"Часы: {h}\t Минуты: {m}\t Секунды: {s}\t Результат: {Timeins()} секунд";
        }
    }

}
