using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson21
{
    class Questions
    {
        public void HediyyeMeselesi(string time1, string time2)
        {
            var subtractSecond = GetSecond(time2) - GetSecond(time1);

            Console.WriteLine(ConvertSecondToHMS(subtractSecond));
        }

        private int GetSecond(string time)
        {
            return int.Parse(time.Substring(0, 2)) * 3600 
                +  int.Parse(time.Substring(3, 2)) * 60 
                +  int.Parse(time.Substring(6));
        }

        private string ConvertSecondToHMS(int second)
        {
            return $"{second / 3600}:{(second % 3600) / 60}:{second % 60}";
        }

        public void HeddiyyeMeselesi2(DateTime time1, DateTime time2)
        {
            var x = time2 - time1;

            Console.WriteLine(x.ToString());
        }   
        
        public void HediyyeMeselesi3(TimeSpan time1,TimeSpan time2)
        {
            var x = time2 - time1;

            Console.WriteLine(x.ToString());
        }

        public void SinusMeselesi(double a, double b, double h)
        {
            //rad format
            for (double i = a; i <= b; i+=h)
            {
                Console.WriteLine($"{i}={3 * Math.Sin(i)}");
            }
        }

        public void SinusMeselesi2(double a, double b, double h)
        {
            //degree format
            for (double i = a; i <= b; i += h)
            {
                Console.WriteLine($"{i}={3 * Math.Sin(i * Math.PI / 180)}");
            }
        }

        public void NaturalBolenler(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                    Console.WriteLine($"{n}/{i}={n / i}");
            }
        }

        public void Ebob(int a, int b)
        {
            for (int i = Math.Min(a,b); i>=1; i--)
            {
                if (a % i == 0 && b % i == 0)
                {
                    Console.WriteLine(i);
                    break;
                }
            }
        }

        public void Ebob(params int[] a)
        {
           //for Emmar
        }
    }
}
