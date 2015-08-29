using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Task
{
    class Triangle
    {
        private double aSide;

        public double Sides
        {
            get { return aSide; }
            set { aSide = value; }
        }
        private double bSide;

        public double BSide
        {
            get { return bSide; }
            set { bSide = value; }
        }

        public Triangle(int aSide, int bSide)
        {
            this.aSide = aSide;
            this.bSide = bSide;
        }

        public double CalculateCside(double a, double b)
        {
            double c =Math.Sqrt(a*a+b*b);
            return c;
        }

        public void CalculateAngles(double a,double b,double c)
        {
            Console.WriteLine(Math.Asin(a/c));
            Console.WriteLine(Math.Acos(b/c));
        }
    }
}
