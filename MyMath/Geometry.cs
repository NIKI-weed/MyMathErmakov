using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMath
{

    public class Algebra
    {
        public static double SquareQuadraticEquation(double a, double b, double c)
        {
            Console.WriteLine("Корни(-ень) квадратного уравнения");
            return (b * b) - 4 * a * c;
        }

        public static double SquareLinearEquation(double D, double a, double b, double x)
        {
            Console.WriteLine("Корни линейного уравнения");
            return D = (a * x) + b;
            if (x != b / a)
            {
                Console.WriteLine($"Один корень + {x}");
            }
            else if (x == b / 0)
            {
                Console.WriteLine("Нет корней");
            }
            else if (x == 0)
            {
                Console.WriteLine("Имеет множество решений");
            }
            return x = (a * x) + b;
        }

        public static double Summ(double[] mass)
        {
            Console.WriteLine("Сумма ряда цифр");
            double sum = 0;
            for (int i = 0; i < mass.Length; i++)
            {
                sum += mass[i];
            }
            return sum;
        }

        public static double Maxi(double[] mass)
        {
            Console.WriteLine("Максимальное из ряда цифр");
            double max = 0;
            for (int i = 0; i < mass.Length; i++)
            {
                if (max < mass[i]) 
                {
                    max = mass[i];
                }
            }
            return max;
        }

        public static double Avg(double[] mass)
        {
            Console.WriteLine("Cреднее из ряда цифр");
            double avg = 0;
            for (int i = 0; i < mass.Length; i++)
            {
                avg += mass[i];
            }
            return avg/mass.Length;
        }
    }

    public class Geometry
    {
        public static double TriangleP(double a, double h)
        {
            Console.WriteLine("Площадь треугольника");
            return 0.5 * a * h;
        }

        public static double StraightTriangleP(double a, double b)
        {
            Console.WriteLine("Площадь прямоугольного треугольника");
            return 0.5 * a * b;
        }

        public static double RectangleP(double a, double b)
        {
            Console.WriteLine("Площадь прямоугольника");
            return a * b;
        }

        public static double RoundP(double r)
        {
            Console.WriteLine("Площадь круга");
            return Math.PI * Math.Pow(r, 2);
        }

        public static double TrapezoidP(double a, double b, double h)
        {
            Console.WriteLine("Площадь трапеции");
            return (a * b) / 2 * h;
        }
    }

    public class Trigonometry
    {
        public static double SinA(double a, double b)
        {
            Console.WriteLine("Sin α");
            return a / b;
        }

        public static double CosA(double a, double b)
        {
            Console.WriteLine("Cos α");
            return a / b;
        }

        public static double TgA(double a, double b)
        {
            Console.WriteLine("Tg α");
            return a / b;
        }

        public static double CtgA(double a, double b)
        {
            Console.WriteLine("Ctg α");
            return a / b;
        }

        public static double ArcSinA(double a, double b)
        {
            Console.WriteLine("ArcSin α");
            return Math.Abs(a / b);
            
        }
    }
}
