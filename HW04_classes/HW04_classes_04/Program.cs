using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW04_classes_04
{
    class Program
    {
        private const int uah = 200;

        static void Main(string[] args)
        {
            Converter a = new Converter(17,20,0.3);
            Console.WriteLine("200 UAH equals to "+ Converter.ConvertToUsd(uah, a.usd)+" USD");
            Console.WriteLine("200 UAH equals to " + Converter.ConvertToEur(uah, a.eur) + " EUR");
            Console.WriteLine("200 UAH equals to " + Converter.ConvertToRub(uah, a.rub) + " RUB");
        }
    }

    class Converter
    {
        public double usd,eur,rub;

        public Converter()
        {
            usd = 1;
            eur = 1;
            rub = 1;
        }

        public Converter(double a, double b, double c)
        {
            usd = a;
            eur = b;
            rub = c;
        }

        static public double ConvertToUsd(double uah, double usd)
        {
            return uah/usd;
        }
        static public double ConvertToEur(double uah, double eur)
        {
            return uah / eur;
        }
        static public double ConvertToRub(double uah, double rub)
        {
            return uah / rub;
        }
    }
}
