using System;

namespace TriangleSurface
{

    class TriangleSurface
    {

        private class Triangle
        {
            private double side;
            private double altitude;

            public double Side
            {
                get
                {
                    return side;
                }
                set
                {
                    side = value;
                }
            }

            public double Altitude
            {
                get
                {
                    return altitude;
                }
                set
                {
                    altitude = value;
                }
            }

            public void CalcSurface()
            {
                Console.WriteLine("{0:f2}", this.Side * this.Altitude / 2);
            }

        }

        static void Main(string[] args)
        {
            Triangle test = new Triangle();
            test.Side = double.Parse(Console.ReadLine());
            test.Altitude = double.Parse(Console.ReadLine());
            test.CalcSurface();
        }
    }
}
