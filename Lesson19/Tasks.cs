using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson19
{
    class Tasks
    {
        public double Area(double a,double b,double alfa)
        {
            //Mathematical : Area = a*b*sin(alfa)/2

            return a * b * Math.Sin(alfa * Math.PI / 180.0) / 2;
        }

        public int OlymUsersCount(int k, int m, int n, int d)
        {
            double x = 1.0 - (double)(k * m + k * n + m * n) / (k * m * n);
            return (int)(double)(d / x);
        }
    }
}
