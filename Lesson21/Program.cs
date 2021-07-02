using System;

namespace Lesson21
{
    class Program
    {
        static void Main(string[] args)
        {
            Questions questions = new Questions();
            //questions.HediyyeMeselesi("12:13:14", "14:07:11");
            //questions.HeddiyyeMeselesi2(new DateTime(1, 1, 1, 12, 13, 14), new DateTime(1, 1, 1, 14, 7, 11));
            //questions.HediyyeMeselesi3(new TimeSpan(12, 13, 14), new TimeSpan(14, 7, 11));
            //questions.SinusMeselesi(1, 3, 0.1);
            //questions.SinusMeselesi2(30, 90, 5);
            //questions.NaturalBolenler(100);
            questions.Ebob(30000, 25);
            questions.Ebob(12);
        }
    }
}
