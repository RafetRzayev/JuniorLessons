using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lesson16
{
    class MathematicOperations
    {
        public double Sum(double a, double b)
        {
            return a + b;
        }

        public void SumVoid(double a, double b)
        {
            Console.WriteLine(a + b);
        }

        public static double SumStatic(double a,double b)
        {
            return a + b;
        }

        public void Swap(int x, int y)
        {
            int tmp = x;
            x = y;
            y = tmp;
        }

        public void Swap(ref int x, ref int y)
        {
            int tmp = x;
            x = y;
            y = tmp;
        }

        public int SumOfDigit(int number, out int numberCount)
        {
            numberCount = (int)Math.Log10(number) + 1;

            int cem = 0;
            while (number != 0)
            {
                cem += number % 10;
                number /= 10;
            }

            return cem;
        }

        public void PrintGivenFiveNumber(int a, int b, int c, int d = 0, int e = 0)
        {
            Console.WriteLine($"{a} {b} {c} {d} {e}");
        }
    }
}
