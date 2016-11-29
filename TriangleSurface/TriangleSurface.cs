using System;

namespace TriangleSurface
{

    class TriangleSurface
    {

        private class Triangle
        {
            private double a;
            private double b;
            private double c;

            public double A
            {
                get
                {
                    return a;
                }
                set
                {
                    a = value;
                }
            }

            public double B
            {
                get
                {
                    return b;
                }
                set
                {
                    b = value;
                }
            }

            public double C
            {
                get
                {
                    return c;
                }
                set
                {
                    c = value;
                }
            }

            public void CalcSurface()
            {
                double s = (this.a + this.b + this.c) / 2;
                Console.WriteLine("{0:f2}", Math.Sqrt(s * (s - this.a) * (s - this.b) * (s - this.c)));
            }

        }

        static void Main(string[] args)
        {
            Triangle test = new Triangle();
            test.A = double.Parse(Console.ReadLine());
            test.B = double.Parse(Console.ReadLine());
            test.C = double.Parse(Console.ReadLine());
            test.CalcSurface();
        }
    }
}
