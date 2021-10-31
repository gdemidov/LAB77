using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB77_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a1, a2, b1, b2, c1, c2, p1, s1, p2, s2;
            Console.WriteLine("Введите длины сторон треугольника 1 (a,b,c):");
            a1 = Convert.ToDouble(Console.ReadLine());
            b1 = Convert.ToDouble(Console.ReadLine());
            c1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Введите длины сторон треугольника 2 (a,b,c):");
            a2 = Convert.ToDouble(Console.ReadLine());
            b2 = Convert.ToDouble(Console.ReadLine());
            c2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            Calc_A(a1, b1, c1, out p1, out s1);
            Calc_A(a2, b2, c2, out p2, out s2);
            Console.Write("Площадь треугольника 1 S= {0:F2}", s1);
            if (s1 > s2) { Console.Write("  >   "); } else { Console.Write("  <   "); }
            Console.WriteLine("Площадь треугольника 2 S= {0:F2}", s2);
            Console.WriteLine("далее...");
            Console.ReadKey();
        }

        static void Calc_A(double a, double b, double c, out double p, out double s)
        // метод вычисление площади треугольника
        {
            p = (a + b + c) / 2;//полупериметр
            s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));//площадь
            p = p * 2;//периметр
        }
    }
}
