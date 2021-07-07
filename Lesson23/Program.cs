using System;
using System.Collections;
using System.Collections.Generic;

namespace Lesson23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] mass1 = new int[3];
            object[] mass1Obsject = new object[2];
            mass1Obsject[0] = "Hello";
            mass1Obsject[1] = 2;

            int x = (int)mass1Obsject[1];

            double s = x;
            x = (int)s;

            var arrayList = new ArrayList
            {
                "hello",
                null
            };

            var arrayList1 = new List<string>
            {
                "Hi"
            };

            Console.WriteLine(arrayList[0]);
            int d = 2;
            object r = d;

            d = (int)r;
            //nullable

            int? number = null;
            Console.WriteLine(number.HasValue);

            //for (int i = 0; i < mass1.Length; i++)
            //{
            //    mass1[i] = int.Parse(Console.ReadLine());
            //}

            //int[,] mass2 = new int[2, 4];
            //int[,,] mass3 = new int[1, 2, 3];


            A a = new A();
            B b = new B();

            a.Print();
            b.Print();

            var keyValuePairs = new Dictionary<int, string>
            {
                 { 5, "five" },
                { 7, "seven" },
                { 10, "ten" },
                { 0, "zero" },
                { 4, "four" },
                { 2, "two" }
            };

          //  Console.WriteLine(keyValuePairs[4]);

            foreach (var item in keyValuePairs)
            {
                Console.WriteLine(item);
            }

            var keyValuePairSorted = new SortedList<int, string>
            {
                { 5, "five" },
                { 7, "seven" },
                { 10, "ten" },
                { 0, "zero" },
                { 4, "four" },
                { 2, "two" }
            };

            foreach (var item in keyValuePairSorted)
            {
                Console.WriteLine(item);
            }


        }
    }
}
