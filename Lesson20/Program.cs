using System;

namespace Lesson20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Enum.GetName(WeekDays.Monday));

            //foreach (var item in Enum.GetNames(typeof(WeekDays)))
            //{
            //    Console.WriteLine(item);
            //}

            //foreach (var item in Enum.GetValues(typeof(WeekDays)))
            //{
            //    Console.WriteLine((int)item);
            //}

            string m = "Monday1";

            //WeekDays wd = (WeekDays)Enum.Parse(typeof(WeekDays), m);
            //Console.WriteLine((int)wd);

            //if(Enum.TryParse(typeof(WeekDays), m, out object wd))
            //{
            //    WeekDays days = (WeekDays)wd;
            //}
            //else
            //{
            //    Console.WriteLine("Can't convert");
            //}

            //string n = "123";

            //if (int.TryParse(n, out int number))
            //{
            //    Console.WriteLine(number);
            //}
            //else
            //{
            //    Console.WriteLine("Can't convert");
            //}

            try
            {
                Console.WriteLine( ThrowExample.Sqrt(-1));
            }
            catch(ArgumentOutOfRangeException e)
            {
                Console.Error.WriteLine("Error: {0}", e);
            }

        }

        enum WeekDays
        {
            Monday,
            Thuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
    }
}
