using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoalSeek
{
    public class BisectionMethod : IGoalSeek
    {
        public delegate double Function(double x);

        public double Seek(double TOL, int MaxIterations, double a, double b, double seekValue, Function f)
        {
            for(int i = 0; i < MaxIterations; i++)
            {
                double c = (a + b) / 2d;

                double fc = f(c);
                double fa = f(a);
                
                if (fc == seekValue || (b-a)/2d < TOL)
                {
                    return c;
                }

                if ((fc < seekValue && fa < seekValue) || (fc > seekValue && fa > seekValue))
                    a = c; 
                else
                    b = c;
            }

            return double.NaN;
        }
    }
}
