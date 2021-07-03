using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson22
{
    class Question
    {
        public int Ebob(params int[] numbers)
        {
            for (int i = GetMin(numbers); i >= 1; i--)
            {
                if (CheckDivide(i, numbers))
                {
                    return i;
                }
            }

            return 1;
        }

        private bool CheckDivide(int n, params int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % n != 0)
                {
                    return false;
                }
            }

            return true;
        }

        private int GetMin(params int[] numbers)
        {
            int min = numbers[0];

            for (int i = 0; i < numbers.Length; i++)
            {
                if (min > numbers[i])
                    min = numbers[i];
            }

            return min;
        }
    }
}
