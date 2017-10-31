using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoalSeek
{
    public class NewtonMethod : IGoalSeek
    {
        public delegate double Function(double x);

        public double Seek(double seekValue, int maxIterations, double a, double cutOff, Function f, Function derF)
        {
            double result = double.MaxValue;
            double x = a;
            double newX = x;
            int count = 0;

            while (Math.Abs(seekValue - result) > cutOff && count < maxIterations)
            {
                newX = x - (f(x) / derF(x));
                result = f(x);
            }

            return result;
        }
    }
}