using System;

namespace TriangleSurface2
{
    class TriangleSurface2
    {
        private class Triangle
        {
            private double a;
            private double b;
            private double angle;

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

            public double Angle
            {
                get
                {
                    return angle;
                }
                set
                {
                    angle = value;
                }
            }

            public void CalcSurface()
            {
                Console.WriteLine("{0:f2}", this.a * this.b * Math.Sin(Math.PI * angle / 180.0) / 2);
            }

        }

        static void Main(string[] args)
        {
            Triangle test = new Triangle();
            test.A = double.Parse(Console.ReadLine());
            test.B = double.Parse(Console.ReadLine());
            test.Angle = double.Parse(Console.ReadLine());
            test.CalcSurface();
        }
    }
}
