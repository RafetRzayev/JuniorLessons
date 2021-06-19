using System;

namespace Lesson18
{
    class Program
    {
        public delegate void Sum(int a, int b);
        static void Main(string[] args)
        {
            //Sum sum = SumPrint;
            //sum.Invoke(3, 4);

            //Sum sum = delegate (int a, int b)
            //  {
            //      Console.WriteLine($"{a}+{b}={a + b}");
            //  };
            //sum.Invoke(3, 4);

            //Func<int, int> func = CountDigit;
            //int count = func.Invoke(123);
            //Console.WriteLine(count);

            //Func<int, int> func1 = delegate (int n)
            //   {
            //       return (int)Math.Log10(n) + 1;
            //   };

            //Console.WriteLine(func1.Invoke(4326));


            //Func<int, int> func2 = (n) => (int)Math.Log10(n) + 1;
            //Console.WriteLine(func2.Invoke(54743));

            Action<int> action = CountDigitPrint;
            action.Invoke(35);

            Action<int> action1 = delegate (int number)
              {
                  Console.WriteLine((int)Math.Log10(number) + 1);
              };
            action1.Invoke(4363);

            Action<int> action2 = number => Console.WriteLine((int)Math.Log10(number) + 1);
            action2.Invoke(464362);
        }

        static void SumPrint(int a, int b)
        {
            Console.WriteLine($"{a}+{b}={a + b}");
        }

        static int CountDigit(int number)
        {
            return (int)Math.Log10(number) + 1;
        }

        static void CountDigitPrint(int number)
        {
            Console.WriteLine((int)Math.Log10(number) + 1);
        }
    }
}
