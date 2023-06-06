using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MyMath;

namespace Main
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine(Algebra.SquareQuadraticEquation(12, 12, 12));
            Console.WriteLine(Algebra.SquareLinearEquation(12, 12, 12, 12));

            double[] mass = new double[10];
            for (int i = 0; i < mass.Length; i++)
                mass[i] = i;
            Console.WriteLine(Algebra.Summ(mass));
            Console.WriteLine(Algebra.Maxi(mass));
            Console.WriteLine(Algebra.Avg(mass));


            Console.WriteLine(Geometry.TriangleP(12, 12));
            Console.WriteLine(Geometry.StraightTriangleP(12, 12));
            Console.WriteLine(Geometry.RectangleP(12, 12));
            Console.WriteLine(Geometry.RoundP(12));
            Console.WriteLine(Geometry.TrapezoidP(12, 12, 12));

            Console.WriteLine(Trigonometry.SinA(12, 12));
            Console.WriteLine(Trigonometry.CosA(12, 12));
            Console.WriteLine(Trigonometry.TgA(12, 12));
            Console.WriteLine(Trigonometry.CtgA(12, 12));
            Console.WriteLine(Trigonometry.ArcSinA(12, 12));

            Console.ReadKey();
        }
    }
}
