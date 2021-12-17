﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab.Core;

namespace Siniak
{
    class Quadro : Linear, EquationInterface
    {
        public List<float> Solve(float a, float b, float c)
        {
            if (a == 0)
            {
                x = SolveLinear(b, c);
                return new List<float>(x);
            }
            SiniakLog.I().Log("Определено, что это квадратное уравнение");
            float D = Discr(a, b, c);
            if (D < 0)
            {
                throw new SiniakException("Ошибка: уравнение не имеет решений.");
            }
            else if (D > 0)
            {
                D =(float) Math.Sqrt(D);
                this.x = new float[] { ((-b) - D) / (2 * a), ((-b) + D) / (2 * a) };
            }
            else
            {
                this.x = new float[] { (-b/2*a) };
            }
            return new List<float>(this.x); ;
        }

        protected float Discr(float a, float b, float c)
        {
        
            return (b*b - 4 * a * c);
            
        }
    }
}
