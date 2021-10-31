using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB77_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, v, s;
            Console.WriteLine("Введите длину ребра куба:");
            a = Convert.ToDouble(Console.ReadLine());
            v = Calc_V(a);
            s = Calc_S(a);
            Console.WriteLine("V= {0:F2}", v);
            Console.WriteLine("S={0:F2}", s);
            Console.ReadKey();
        }
        static double Calc_V(double a)
        {
            double v = (a * a * a);//объем куба
            return v;
        }
        static double Calc_S(double a)
        {
            double s = (12 * a * a);//площадь поверхностей куба
            return s;
        }
    }
}
