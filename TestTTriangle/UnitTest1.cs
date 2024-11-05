using labTTriangle;
using System;
using System.Drawing;

namespace TestTTriangle
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CorrectSides()
        {
            double a = 3;
            double b = 4;
            double c = 5;

            var triangle = new TTriangle(a, b, c);

            Assert.AreEqual(3, triangle.A);
            Assert.AreEqual(4, triangle.B);
            Assert.AreEqual(5, triangle.C);
        }

        [Test]
        public void NotCorrectSides()
        {
            Assert.Throws<ArgumentException>(() => new TTriangle(-3, -4, 0));
        }

        [Test]
        public void TriangleNotExist()
        {
            Assert.Throws<ArgumentException>(() => new TTriangle(1, 2, 4));
        }

        [Test]
        public void GetPerimeter()
        {
            TTriangle tr = new TTriangle(3, 4, 5);

            double expectedPerimeter = tr.A + tr.B + tr.C;
            double perimeter = tr.GetPerimeter();

            Assert.AreEqual(expectedPerimeter, perimeter);
        }

        [Test]
        public void GetArea_ValidSides_ReturnsCorrectArea()
        {
            TTriangle tr = new TTriangle(3, 4, 5);

            double pivPer = (tr.A + tr.B + tr.C) / 2;

            double expectedArea = Math.Sqrt(pivPer * (pivPer - tr.A) * (pivPer - tr.B) * (pivPer - tr.C));
            double area = tr.GetArea();

            Assert.AreEqual(expectedArea, area);
        }

        [Test]
        public void SetA_and_B_and_C_PositiveSides()
        {
            TTriangle triangle = new TTriangle(3, 4, 5);

            triangle.A = 6;
            triangle.B = 8;
            triangle.C = 10;

            Assert.AreEqual(6, triangle.A);
            Assert.AreEqual(8, triangle.B);
            Assert.AreEqual(10, triangle.C);
        }

        [Test]
        public void SetA_and_B_and_C_NotPositiveSides()
        {
            TTriangle triangle = new TTriangle(3, 4, 5);

            Assert.Throws<ArgumentException>(() => triangle.A = -5);
            Assert.Throws<ArgumentException>(() => triangle.B = -3);
            Assert.Throws<ArgumentException>(() => triangle.C = -4);
        }
    }
}