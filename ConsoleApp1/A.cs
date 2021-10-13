using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class A
    {
        protected double x;
        public double getX()
        {
            return x;
        }

        public double Linear(double a, double b)
        {
            if (a == 0)
            {
                throw new Exception("x любое число");
            }
             return this.x = (- b) / a;
           //this.x;
        }
    }
}
