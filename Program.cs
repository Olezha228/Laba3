using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторка3
{
    class Program
    {
        static void Main(string[] args)
        {
            double e = 0.0001; // заданная точность
            double y; //  значение функции
            double a; // текущее слагаемое ряда 
            double x = 0; // шаг функции по оси Ох
            int n;  // количество слагаемых в ряде
            for (int i = 1; i <= 10; i++)
            {
                x = x + 0.1;
                Console.Write($"x = {x} ");

                double SN = 1;
                int fact = 1;
                for (n=1; n <= 20; n++)
                {
                    fact = fact * n;
                    a = Math.Cos(n * x) / fact;
                    SN = SN + a;  
                }

                Console.Write($"SN = {Math.Round(SN, 4)} ");


                double SE = 1;
                int schetchik = 2;
                fact = 1;
                a = Math.Cos(x)/fact;
                SE = SE + a;
                while (Math.Abs(a) > e)
                {
                    fact = fact * schetchik;
                    a = Math.Cos(schetchik * x) / fact;
                    SE = SE + a;
                    schetchik++;
                }

                Console.Write($"SE = {Math.Round(SE, 4)} ");

             
                y = Math.Exp(Math.Cos(x)) * Math.Cos(Math.Sin(x));
                Console.WriteLine($"y = {Math.Round(y, 4)} ");

            }

        }
    }
}
