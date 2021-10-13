using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siniak
{
    class Linear
    {
        protected float[] x;
        public float[] getX()
        {
            return x;
        }

        public float[] SolveLinear(float a, float b)
        {
            if (a == 0)
            {
                throw new Exception("x любое число");
            }
            this.x = new float[1];
            return this.x = new float[1] { (-b) / a };
        }
    }
}
