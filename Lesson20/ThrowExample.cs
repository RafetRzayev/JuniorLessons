using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson20
{
    class ThrowExample
    {
        public static double Sqrt(double value)
        {
            if (value < 0)
                throw new System.ArgumentOutOfRangeException(
                   "Sqrt for negative numbers is undefined!");
            return Math.Sqrt(value);
        }

    }
}
