using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MyMath;

namespace UnitTestProject1
{
    [TestClass]
    public class GeometryUnitTest1
    {
        [TestMethod]
        public void TestMethoda12b12s144()
        {
            double a = 12, b = 12, s = 144;

            double res = Geometry.RectangleP(a, b);

            Assert.AreEqual(s, res);
        }

        [TestMethod]
        public void TestMethoda1b1s1()
        {
            double a = 1, b = 1, s = 1;

            double res = Geometry.RectangleP(a, b);

            Assert.AreEqual(s, res);
        }

        [TestMethod]
        public void TestMethoda2b2s4()
        {
            double a = 2, b = 2, s = 4;

            double res = Geometry.RectangleP(a, b);

            Assert.AreEqual(s, res);
        }

        [TestMethod]
        public void TestMethoda10h10s50()
        {
            double a = 10, h = 10, s = 50;

            double res = Geometry.TriangleP(a, h);

            Assert.AreEqual(s, res);
        }

        [TestMethod]
        public void TestMethod1a3h3s45()
        {
            double a = 3, h = 3, s = 4.5;

            double res = Geometry.TriangleP(a, h);

            Assert.AreEqual(s, res);
        }


        [TestMethod]
        public void TestMethod1a4h4s6()
        {
            double a = 4, h = 4, s = 8;

            double res = Geometry.TriangleP(a, h);

            Assert.AreEqual(s, res);
        }


        [TestMethod]
        public void TestMethod1a5b5s125()
        {
            double a = 5, b = 5, s = 12.5;

            double res = Geometry.StraightTriangleP(a, b);

            Assert.AreEqual(s, res);
        }


        [TestMethod]
        public void TestMethod1a6b6s18()
        {
            double a = 6, b = 6, s = 18;

            double res = Geometry.StraightTriangleP(a, b);

            Assert.AreEqual(s, res);
        }

        [TestMethod]
        public void TestMethod1a7b7s245()
        {
            double a = 7, b = 7, s = 24.5;

            double res = Geometry.StraightTriangleP(a, b);

            Assert.AreEqual(s, res);
        }

        [TestMethod]
        public void TestMethod1r2s1256()
        {
            double r = 2, s = 12.5663706143592;

            double res = Geometry.RoundP(r);

            Assert.AreEqual(s, res);
        }

        [TestMethod]
        public void TestMethod1r3s2827()
        {
            double r = 3, s = 28.2743338823081;

            double res = Geometry.RoundP(r);

            Assert.AreEqual(s, res);
        }

        [TestMethod]
        public void TestMethod1r4s5026()
        {
            double r = 4, s = 50.2654824574367;

            double res = Geometry.RoundP(r);

            Assert.AreEqual(s, res);
        }

        [TestMethod]
        public void TestMethod1a4b4h5s40()
        {
            double a = 4, b = 4, h = 5, s = 40;

            double res = Geometry.TrapezoidP(a, b, h);

            Assert.AreEqual(s, res);
        }

        [TestMethod]
        public void TestMethod1a3b3h5s225()
        {
            double a = 3, b = 3, h = 5, s = 22.5;

            double res = Geometry.TrapezoidP(a, b, h);

            Assert.AreEqual(s, res);
        }

        [TestMethod]
        public void TestMethod1a2b2h5s10()
        {
            double a = 2, b = 2, h = 5, s = 10;

            double res = Geometry.TrapezoidP(a, b, h);

            Assert.AreEqual(s, res);
        }
    }

    [TestClass]
    public class TrigonometryUnitTest1
    {
        [TestMethod]
        public void TestMethoda1a12b6s2()
        {
            double a = 12, b = 6, s = 2;

            double res = Trigonometry.SinA(a, b);

            Assert.AreEqual(s, res);
        }

        [TestMethod]
        public void TestMethoda1a10b5s2()
        {
            double a = 10, b = 5, s = 2;

            double res = Trigonometry.SinA(a, b);

            Assert.AreEqual(s, res);
        }

        [TestMethod]
        public void TestMethoda1a8b2s4()
        {
            double a = 8, b = 2, s = 4;

            double res = Trigonometry.SinA(a, b);

            Assert.AreEqual(s, res);
        }

        [TestMethod]
        public void TestMethoda1()
        {
            double a = 24, b = 8, c = 4;

            double res = Trigonometry.CosA(a, b);

            Assert.AreEqual(c, res);
        }

        [TestMethod]
        public void TestMethoda1a36b6c6()
        {
            double a = 36, b = 6, c = 6;

            double res = Trigonometry.CosA(a, b);

            Assert.AreEqual(c, res);
        }
        [TestMethod]
        public void TestMethoda1a4b4c1()
        {
            double a = 4, b = 4, c = 1;

            double res = Trigonometry.CosA(a, b);

            Assert.AreEqual(c, res);
        }
        [TestMethod]
        public void TestMethoda1a4b4t1()
        {
            double a = 4, b = 4, t = 1;

            double res = Trigonometry.TgA(a, b);

            Assert.AreEqual(t, res);
        }
        [TestMethod]
        public void TestMethoda1a6b2t3()
        {
            double a = 6, b = 3, t = 2;

            double res = Trigonometry.TgA(a, b);

            Assert.AreEqual(t, res);
        }
        [TestMethod]
        public void TestMethoda1a12b3t4()
        {
            double a = 12, b = 3, t = 4;

            double res = Trigonometry.TgA(a, b);

            Assert.AreEqual(t, res);
        }
        [TestMethod]
        public void TestMethoda1a12b3ct4()
        {
            double a = 12, b = 3, ct = 4;

            double res = Trigonometry.CtgA(a, b);

            Assert.AreEqual(ct, res);
        }
        [TestMethod]
        public void TestMethoda1a14b2ct7()
        {
            double a = 14, b = 2, ct = 7;

            double res = Trigonometry.CtgA(a, b);

            Assert.AreEqual(ct, res);
        }
        [TestMethod]
        public void TestMethoda1a32b8t4()
        {
            double a = 32, b = 8, ct = 4;

            double res = Trigonometry.CtgA(a, b);

            Assert.AreEqual(ct, res);
        }
        [TestMethod]
        public void TestMethoda1a12b3arc4()
        {
            double a = 12, b = 3, arc = 4;

            double res = Trigonometry.ArcSinA(a, b);

            Assert.AreEqual(arc, res);
        }
        [TestMethod]
        public void TestMethoda1a14b2arc7()
        {
            double a = 14, b = 2, arc = 7;

            double res = Trigonometry.ArcSinA(a, b);

            Assert.AreEqual(arc, res);
        }
        [TestMethod]
        public void TestMethoda1a32b8arc4()
        {
            double a = 32, b = 8, arc = 4;

            double res = Trigonometry.ArcSinA(a, b);

            Assert.AreEqual(arc, res);
        }
    }
    [TestClass]
    public class AlgebraUnitTest1
    {
        [TestMethod]
        public void TestMethoda1a12b6s2()
        {
            double a = 12, b = 6, s = 2;

            double res = Algebra.SinA(a, b);

            Assert.AreEqual(s, res);
        }

        [TestMethod]
        public void TestMethoda1a10b5s2()
        {
            double a = 10, b = 5, s = 2;

            double res = Algebra.SinA(a, b);

            Assert.AreEqual(s, res);
        }

        [TestMethod]
        public void TestMethoda1a8b2s4()
        {
            double a = 2, b = 4, c = 2, x = ;

            double res = Algebra.SquareQuadraticEquation(a, b, c);

            Assert.AreEqual(x, res);
        }
    }
}
