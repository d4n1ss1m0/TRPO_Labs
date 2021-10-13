using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class B : A
    {

        protected double x2;

        public double getX2()
        {
            return this.x2;
        }


        public double[] Quadr(double a, double b, double c)
        {
            if (a == 0)
            {
                
                return new double[] { Linear(b, c) };               
            }
            double D = Discr(a, b, c);
            if (D < 0)
            {
                throw new Exception("D<0, корней нет");
            }
            if (D > 0)
            {
                D = Math.Sqrt(D);
                this.x = ((-b) - D) / (2 * a);
                this.x2 = ((-b) + D) / (2 * a);
            }
            else
            {
                this.x = 0;
                this.x2 = -(b / a);
            }
            return new double[] { this.x, this.x2 };
        }

        protected double Discr(double a, double b, double c)
        {
        
            return (Math.Pow(b, 2) - 4 * a * c);
            
        }
    }
}
