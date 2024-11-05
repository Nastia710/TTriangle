using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labTTriangle
{
    public class TTriangle
    {
        private double a, b, c;
        public TTriangle(double a, double b, double c)
        {

            if (IsValidate (a, b, c))
            {
                this.a = a;
                this.b = b;
                this.c = c;
            }
        }

        public static bool IsValidate (double a, double b, double c)
        {
            bool isValidate = true;

            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new ArgumentException("Довжини сторiн обов'язково повинi бути додатні");
            }

            if (a + b <= c || b + c <= a || a + c <= b)
            {
                throw new ArgumentException("Трикутника з такими сторонами не існує");
            }

            return isValidate;
        }

        public double A
        {
            get { return a; }

            set
            {
                if (IsValidate(value, b, c))
                {
                    a = value;
                }
                
                else
                {
                    throw new ArgumentException("Не вдається створити трикутник");
                }
            }
        }

        public double B
        {
            get { return b; }

            set
            {
                if (IsValidate(a, value, c))
                {
                    b = value;
                }

                else
                {
                    throw new ArgumentException("Не вдається створити трикутник");
                }
            }
        }

        public double C
        {
            get { return c; }

            set
            {
                if (IsValidate(a, b, value))
                {
                    c = value;
                }

                else
                {
                    throw new ArgumentException("Не вдається створити трикутник");
                }
            }
        }

        public double GetPerimeter()
        {
            return a + b + c;
        }

        public double GetArea()
        {
            double pivPer = GetPerimeter() / 2;
            return Math.Sqrt(pivPer * (pivPer - a) * (pivPer - b) * (pivPer - c));
        }
    }
}
